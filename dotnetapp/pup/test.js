const puppeteer = require('puppeteer');

(async () => {
  const browser = await puppeteer.launch({
    headless: "new", // Use the new Headless mode
    args: [
      '--headless',
      '--disable-gpu',
      '--remote-debugging-port=9222',
      '--no-sandbox',
      '--disable-setuid-sandbox',
    ],
  });

  const createPage = async (url, width, height) => {
    const page = await browser.newPage();
    await page.goto(url);
    await page.setViewport({ width, height });
    return page;
  };

  try {
    // Testcase 1: Check if headers are correct
    const page = await createPage('https://8081-beeafcabeefc308594452bffbfedcbone.premiumproject.examly.io/', 1200, 1200);

    const headers = await page.evaluate(() => {
      const thElements = Array.from(document.querySelectorAll('table th'));
      return thElements.map(th => th.textContent.trim());
    });

    if (headers[0] === 'Employee ID' && headers[1] === 'Name') {
      console.log('TESTCASE:Headers_are_correct:success');
    } else {
      console.log('TESTCASE:Headers_are_correct:failure');
    }

    // Testcase 2: Check if the search button exists
    const page1 = await createPage('https://8081-beeafcabeefc308594452bffbfedcbone.premiumproject.examly.io/', 1200, 800);

    const searchButtonExists = await page1.evaluate(() => {
      const searchButton = document.querySelector('button[type="submit"]');
      return !!searchButton; // Return true if the button exists, false otherwise
    });

    if (searchButtonExists) {
      console.log('TESTCASE:Search_button_exists:success');
    } else {
      console.log('TESTCASE:Search_button_exists:failure');
    }

    // Testcase 3: Form submission
    const page2 = await createPage('https://8081-beeafcabeefc308594452bffbfedcbone.premiumproject.examly.io/Employee/Create', 1200, 800);

    await page2.type('input[name="Name"]', 'John Doe');
    await page2.type('input[name="DOB"]', '1990-01-01');
    await page2.type('input[name="Gender"]', 'Male');
    await page2.type('input[name="Department"]', 'IT');
    await page2.type('input[name="Position"]', 'Developer');
    await page2.type('input[name="salary"]', '50000');
    await page2.type('input[name="Email"]', 'john@example.com');
    await page2.type('input[name="phoneNumber"]', '123-456-7890');
    await page2.type('input[name="Address"]', '123 Main St');

    // Submit the form
    await page2.click('input[type="submit"]');
    console.log('TESTCASE:Form_submission_successful:success');
  } catch (e) {
    console.error('Error during test execution:', e);
  } finally {
    await browser.close();
  }
})();
