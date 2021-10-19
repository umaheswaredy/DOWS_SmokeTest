using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOWS_SmokeTest.com.DOWS.PageFactorys
{
    class DOWS_Pages_Elements
    {

        [FindsBy(How = How.XPath, Using = "//a/div[@class='c_headerfunction text-light']")]
        public IWebElement DOWS_FunctionName { get; set; }

        [FindsBy(How = How.XPath, Using = "(//ul/li[@class='Hover']/a)[3]")]
        public IWebElement DOWS_FunctionName_Select { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Courses list')]")]
        public IWebElement DOWS_CourseList_Tab { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Add Course')]")]
        public IWebElement DOWS_AddCourse_Tab { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coursetitle']")]
        public IWebElement DOWS_EnterCoourse_Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='DLCCourseNumber']")]
        public IWebElement DOWS_EnterDLC_CourseNo { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='1609a452-4a89-44bf-9dae-e509b5de0c71']")]
        public IWebElement DOWS_SponsoredandDelivered { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div/div[2]/ul/li[2]")]
        public IWebElement DOWS_SponsoredandDelivered_Local { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/main/div[2]/div/form/div[1]/div/div[1]/div[5]/span/span/span[2]")]
        public IWebElement DOWS_DeliveryTypeDWDN { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div[2]/ul/li[1]")]      
        public IWebElement DOWS_DeliveryTypeDwdnValue { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/main/div[2]/div/form/div[1]/div/div[1]/div[7]/span/span/span[2]")]
        public IWebElement DOWS_DLCCourseStatusDwn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[9]/div/div[2]/ul/li[3]")]
        public IWebElement DOWS_DLCCourseStatusDwnValue { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div[2]/div/form/div[1]/div/div[1]/div[7]/span/span/span[2]")]
        public IWebElement DOWS_FiscalYearDwn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div/div[2]/ul/li[10]")]
        public IWebElement DOWS_FiscalYearDwnValue { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div[2]/div/form/div[1]/div/div[1]/div[8]/span/span/span[2]")]
        public IWebElement DOWS_LearningYearDwn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div[2]/ul/li[11]")]
        public IWebElement DOWS_LearningYearDwnValue { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div[2]/div/form/div[1]/div/div[1]/div[9]/span/span/span[2]")]
        public IWebElement DOWS_CurriculumDwn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[8]/div/div[2]/ul/li[1]")]
        public IWebElement DOWS_CurriculumDwnValue { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div[2]/div/form/div[1]/div/div[1]/div[10]/span/span/span[2]")]
        public IWebElement DOWS_LocaleDwn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[9]/div/div[2]/ul/li[1]")]
        public IWebElement DOWS_LocaleValue { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div[2]/div/form/div[1]/div/div[1]/div[11]/span/span/span[2]")]
        public IWebElement DOWS_LocaleServiceDwn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[10]/div/div[2]/ul/li[2]")]
        public IWebElement DOWS_LocaleServiceLineValue { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div[2]/div/form/div[1]/div/div[1]/div[12]/span/span/span[2]")]
        public IWebElement DOWS_Cur_PortDwn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[11]/div/div[2]/ul/li[2]")]
        public IWebElement DOWS_Cur_PortDwnValue { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div[2]/div/form/div[1]/div/div[1]/div[13]/span/span/span[2]")]
        public IWebElement DOWS_Program_SubTypeDwn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[12]/div/div[2]/ul/li[1]")]
        public IWebElement DOWS_Program_SubTypeValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='LearningHours']")]
        public IWebElement DOWS_LHours { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='CPEhours']")]
        public IWebElement DOWS_CPEHours { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div[2]/div/form/div[1]/div/div[1]/div[16]/span/span/span[2]")]
        public IWebElement DOWS_ContentOwnerDwn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[13]/div/div[2]/ul/li[1]")]
        public IWebElement DOWS_ContentOwner_Value { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div[2]/div/form/div[1]/div/div[1]/div[17]/span/span/span[2]")]
        public IWebElement DOWS_CreatedByVerder_Dwn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[14]/div/div[2]/ul/li[2]")]
        public IWebElement DOWS_CreatedByVerder_Value { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div[2]/div/form/div[1]/div/div[1]/div[18]/span/span/span[2]")]
        public IWebElement DOWS_ContentCreated { get; set; }

        [FindsBy(How = How.XPath, Using = "//tbody[@role='rowgroup']/tr/td")]
        public IWebElement DOWS_ContentCreated_Date { get; set; }
        

        [FindsBy(How = How.XPath, Using = "/html/body/main/div[2]/div/form/div[1]/div/div[1]/div[18]/span/span/span[2]")]
        public IWebElement DOWS_ContentLast_Updated { get; set; }

        [FindsBy(How = How.XPath, Using = "//tbody[@role='rowgroup']/tr/td/span")]
        public IWebElement DOWS_ContentLast_Updated_Date { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div[2]/div/form/div[1]/div/div[1]/div[20]/span/span/span[2]")]
        public IWebElement DOWS_Framework_Dwn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[17]/div/div[2]/ul/li[2]")]
        public IWebElement DOWS_Framework_Value { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div[2]/div/form/div[1]/div/div[1]/div[21]/input")]
        public IWebElement DOWS_Content_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div[2]/div/form/div[1]/div/div[1]/div[22]/span/span/span[2]")]
        public IWebElement DOWS_GPSGroup_Dwn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[18]/div/div[2]/ul/li[1]")]
        public IWebElement DOWS_GPSGroup_Value { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div[2]/div/form/div[1]/div/div[1]/div[23]/span/span/span[2]")]
        public IWebElement DOWS_GPSTier_Dwn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[19]/div/div[2]/ul/li[2]")]
        public IWebElement DOWS_GPSTier_Value { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstOfferingDeliveryDate']")]
        public IWebElement DOWS_FirstOfferingDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@data-id='27a62984-7f2f-4e4a-a5d0-da739c7a3097']")]
        public IWebElement DOWS_MultipleOfferings { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div[2]/div/form/div[1]/div/div[3]/div[8]/span/span/span[2]")]
        public IWebElement DOWS_PPDSponsor_Dwn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[28]/div/div/ul/li[1]/span")]
        public IWebElement DOWS_PPDSponsor_Value { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='726efb83-6de2-4ba5-b09f-ea835dbe38a7']")]
        public IWebElement DOWS_Course_Reviewer { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='DU' and @value='Yes']")]
        public IWebElement DOWS_HeldAtDeloitte { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='569a23fa-47a6-4a4c-805b-3217a9194e61']")]
        public IWebElement DOWS_Prerequisites{ get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='e5d041bc-d006-4636-9725-655a330e8124']")]
        public IWebElement DOWS_AdvancedPreparation { get; set; }


        [FindsBy(How = How.XPath, Using = "//input[@data-id='90ea532c-1c56-4107-bf29-5d4befc7cc1a']")]
        public IWebElement DOWS_NewCourse_CheckBx { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@data-id='8f3cd234-c52e-4461-b5f1-6a638211620a']")]
        public IWebElement DOWS_StandAlone_Course { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@id='a42d0e25-4ad5-4090-82c0-a741a7421e35']")]
        public IWebElement DOWS_Course_Type_Dwn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[29]/div/div[2]/ul/li[2]")]
        public IWebElement DOWS_Course_Type_Vale { get; set; }



        [FindsBy(How = How.XPath, Using = "//span[@id='c80f6465-a42c-43e6-a969-f6704479df9d']")]
        public IWebElement DOWS_Course_Content_Status_Dwn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[30]/div/div[2]/ul/li[1]")]
        public IWebElement DOWS_Course_Content_Status_Value { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='fdffb501-3e38-48f8-90c0-fce627dc7158']")]
        public IWebElement DOWS_Planning_status_Dwn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[31]/div/div[2]/ul/li[3]")]
        public IWebElement DOWS_Planning_status_Value { get; set; }
    }
}
