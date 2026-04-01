using PolymorphismApplication;

PaymentDetails pmtd = new PaymentDetails();

pmtd.makePayment("1234-5678-9876-6789", "Kishore");

pmtd.makePayment("1234-5678-9876-6789", "Kishore", "1234");

pmtd.makePayment(1500.00);


Payment pay1 = new CreditCardPayment(200.00, "Kishore", "1234-5678-9009-8765");
pay1.processPayment();
Payment pay2 = new DebitCardPayment(150.00, "Kumar", "4321-1234-5678-9009");
pay2.processPayment();
Payment pay3 = new CashPayment(100.00, "Kishore");
pay3.processPayment();
Payment test = new Test(200.00, "Kumar");
test.processPayment();