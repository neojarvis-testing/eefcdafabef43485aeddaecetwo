const puppeteer = require('puppeteer');
(async () => {
    const browser = await puppeteer.launch({
      headless: false,
      args: ['--headless', '--disable-gpu', '--remote-debugging-port=9222', '--no-sandbox', '--disable-setuid-sandbox']
    });

    const page = await browser.newPage();
    try{
      await page.goto('https://8081-eefcdafabef43485aeddaecetwo.ide.exam.ly/');
      await page.setViewport({
        width:1200,
        height:1200,
      })
        
      const headers = await page.evaluate(() => {
        const thElements = Array.from(document.querySelectorAll('table th'));
        return thElements.map(th => th.textContent.trim());
      });
    //   console.log(headers);
      if (headers[0] === 'Employee ID' && headers[1] === 'Name'){
      console.log('TESTCASE:Headers_are_correct:success');
      }else{
        console.log('TESTCASE:Headers_are_correct:failure');
      }
    }
    catch(e){
      console.log('TESTCASE:Headers_are_correct:failure');
    }

    const page1 = await browser.newPage();

    try {        
      await page1.goto('https://8081-eefcdafabef43485aeddaecetwo.ide.exam.ly/');
      await page1.setViewport({
        width: 1200,
        height: 800,
      });
    
      // Check if the search button exists
      const searchButtonExists = await page1.evaluate(() => {
        const searchButton = document.querySelector('button[type="submit"]');
        return !!searchButton; // Return true if the button exists, false otherwise
      });
    
      if (searchButtonExists) {
        console.log('TESTCASE:Search_button_exists:success');
      } else {
        console.log('TESTCASE:Search_button_exists:failure');
      }
    }
  catch(e){
    console.log('TESTCASE:Search_button_exists:failure');
  }
    
    const page2 = await browser.newPage();
    try{
      await page2.goto('https://8081-eefcdafabef43485aeddaecetwo.ide.exam.ly/Employee/Create');
      await page2.setViewport({
        width:1200,
        height:800,
      })

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
    //   await page2.waitForSelector('.success-message', { timeout: 5000 });

      console.log('TESTCASE:Form_submission_successful:success');
      
    }
    catch(e){
      console.log('TESTCASE:Form_submission_successful:failure');
    } 
  
  finally{
    await page.close();
    await page1.close();
    await page2.close();
    // await page3.close();
    // await page5.close();
    // await page6.close();
    // await page7.close();
    // await page8.close();
    await browser.close();
  }
  
})();