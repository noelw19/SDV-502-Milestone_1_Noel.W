using NUnit.Framework;

namespace StateCinema.Tests
{
    [TestFixture]
    public class StateCinemaPriceControllerTests
    {
        //if ticket quantity == 1 && person == adult && day == monday && time == 4 Expect 14.50
        [TestCase(1, "Adult", "monday", 4, 14.50)]
        [TestCase(2, "Adult", "monday", 4, 29)]
        [TestCase(0, "Adult", "monday", 4, -1)]
        [TestCase(1, "Student", "monday", 4, -1)]
        [TestCase(1, "Adult", "monday", 6, -1)]
        
        //I have set up the test cases so that 2 will pass and 3 will fail to show the types of input values may cause a fail
        //I did not add any values that would cause type errors because of c#'s strictly typed values
        //initialising parameters of the function to take test case data as arguments 
        public void When_Adult_Before_5_Expect_Price_Or_False(int quantity, string person, string day, decimal time, decimal expects)
        {
            //initialising the price controller class as tcp under the TicketPriceController type
            TicketPriceController tpc = new TicketPriceController();
            // val receives the returned value of the tpc method used with the current test case data set
            decimal val = tpc.Adult_Before_5(quantity, person, day, time);
            //the are equal method takes the value to check as the first argument and the expected value as the second
            Assert.AreEqual(val, expects);
        }
        
        [TestCase(1, "Adult", "monday", 6, 17.50)]
        [TestCase(2, "Adult", "monday", 6, 35)]
        [TestCase(0, "Adult", "monday", 7, -1)]
        [TestCase(1, "Student", "monday", 4, -1)]
        [TestCase(1, "Adult", "monday", 4, -1)]
        
        public void When_Adult_After_5_Expect_Price_Or_False(int quantity, string person, string day, decimal time, decimal expects)
        {
            TicketPriceController tpc = new TicketPriceController();
            decimal val = tpc.Adult_After_5(quantity, person, day, time);
            Assert.AreEqual(val, expects);
        }
        
        [TestCase(1, "Adult", "tuesday",  13)]
        [TestCase(2, "Adult", "tuesday", 26)]
        [TestCase(0, "Adult", "tuesday", -1)]
        [TestCase(1, "Student", "tuesday", -1)]
        [TestCase(1, "Adult", "monday", -1)]
        
        public void When_Adult_Tuesday_Expect_Price_Or_False(int quantity, string person, string day, decimal expects)
        {
            TicketPriceController tpc = new TicketPriceController();
            decimal val = tpc.Adult_Tuesday(quantity, person, day);
            Assert.AreEqual(val, expects);
        }
        
        [TestCase(1, "child",  12)]
        [TestCase(2, "child",  24)]
        [TestCase(0, "child", -1)]
        [TestCase(1, "Student", -1)]
        [TestCase(1, "Adult", -1)]
        
        public void When_Child_Under_16_Expect_Price_Or_False(int quantity, string person, decimal expects)
        {
            TicketPriceController tpc = new TicketPriceController();
            decimal val = tpc.Child_Under_16(quantity, person);
            Assert.AreEqual(val, expects);
        }
        
        [TestCase(1, "senior",  12.50)]
        [TestCase(2, "senior",  25)]
        [TestCase(0, "senior", -1)]
        [TestCase(1, "Student", -1)]
        [TestCase(1, "Adult", -1)]
        
        public void When_Senior_Expect_Price_Or_False(int quantity, string person, decimal expects)
        {
            TicketPriceController tpc = new TicketPriceController();
            decimal val = tpc.Senior(quantity, person);
            Assert.AreEqual(val, expects);
        }
        
        [TestCase(1, "student",  14)]
        [TestCase(2, "student",  28)]
        [TestCase(0, "student", -1)]
        [TestCase(1, "Senior", -1)]
        [TestCase(1, "Adult", -1)]
        
        public void When_Student_Expect_Price_Or_False(int quantity, string person, decimal expects)
        {
            TicketPriceController tpc = new TicketPriceController();
            decimal val = tpc.Student(quantity, person);
            Assert.AreEqual(val, expects);
        }
        
        [TestCase(1, 2, 2, 46)]
        [TestCase(1, 1,  3, 46)]
        [TestCase(8, 4, 4, -1)]
        [TestCase(1, 0, 2, -1)]
        [TestCase(1, 2, 0, -1)]
        
        public void When_Family_Pass_Expect_Price_Or_False(int quantityTicket, int quantityAdult, int quantityChild, decimal expects)
        {
            TicketPriceController tpc = new TicketPriceController();
            decimal val = tpc.Family_Pass(quantityTicket, quantityAdult, quantityChild);
            Assert.AreEqual(val, expects);
        }
        
        [TestCase(1, "adult", "thursday", 21.50)]
        [TestCase(2, "adult", "thursday", 43)]
        [TestCase(0, "adult", "thursday", -1)]
        [TestCase(1, "student", "thursday", -1)]
        [TestCase(1, "adult", "monday", -1)]
        
        public void When_Chick_Flick_Thursday_Expect_Price_Or_False(int quantity, string person, string day, decimal expects)
        {
            TicketPriceController tpc = new TicketPriceController();
            decimal val = tpc.Chick_Flick_Thursday(quantity, person, day);
            Assert.AreEqual(val, expects);
        }
        
        [TestCase(1,  "wednesday", false, 12)]
        [TestCase(2,  "wednesday", false, 24)]
        [TestCase(0, "wednesday", true, -1)]
        [TestCase(1,  "thursday", false, -1)]
        [TestCase(1, "monday", false, -1)]
        
        public void When_Kids_And_Carers_Expect_Price_Or_False(int quantity,string day, bool isHoliday, decimal expects)
        {
            TicketPriceController tpc = new TicketPriceController();
            decimal val = tpc.Kids_And_Carers(quantity, day, isHoliday);
            Assert.AreEqual(val, expects);
        }
        
    }
}