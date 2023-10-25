// See https://aka.ms/new-console-template for more information
using Pizzastore2;

CustomerRepository customerRepository = new CustomerRepository();
PizzaRepository pizzaRepository = new PizzaRepository();

Customer c1 = new Customer("Jens Jensen","12121212","Jens@gmail.com","Køgevej 7,4600");
Customer c2 = new Customer("Morten Hansen", "13131313", "Morten@gmail.com", "Vordinborgvej 5,4600");
customerRepository.AddCustomer(c1);
customerRepository.AddCustomer(c2);


Pizza p1 = new Pizza(1, "Basic AF", 85, "tomato, cheese");
Pizza p2 = new Pizza(2, "Hawaii", 90, "tomato, cheese, ham, pineapple");
pizzaRepository.AddPizza(p1);
pizzaRepository.AddPizza(p2);



UserDialog userDialog = new UserDialog(customerRepository, pizzaRepository);

userDialog.Run();
