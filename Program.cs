using Bank;
using ConsoleTools;
using System.Threading.Channels;

AccountOperations accountOperations = new AccountOperations();
void Action1()
{
    Console.WriteLine("Action 1");
    Console.ReadKey();
}

void Action2()
{
    Console.WriteLine("Action 2");
    Console.ReadKey();
}

void Action3()
{
    Console.WriteLine("Action 3");
    Console.ReadKey();
}



var subMenu = new ConsoleMenu(args, level: 1)
        .Add("Sub_three", () => Action1())
        .Add("Sub_Two", () => Action2())
        .Add("Sub_Three", () => Action3())
        .Add("Sub_Close", ConsoleMenu.Close)
        .Configure(config =>
        {
            config.Selector = "--> ";
            config.EnableFilter = false;
            config.Title = "Submenu";
            config.EnableBreadcrumb = true;
            config.WriteBreadcrumbAction = titles => Console.WriteLine(string.Join(" / ", titles));
        });

var menu = new ConsoleMenu(args, level: 0)
  .Add("Create a new account", () => accountOperations.CreateNewAccount())
  .Add("Check accounts", () => accountOperations.CheckAccounts())
  .Add("Three", () => Action3())
  .Add("Sub", subMenu.Show)
  //.Add("Change me", (thisMenu) => thisMenu.CurrentItem.Name = "I am changed!")
  .Add("Close", ConsoleMenu.Close)
  //.Add("Action then Close", (thisMenu) => { SomeAction("Close"); thisMenu.CloseMenu(); })
  .Add("Exit", () => Environment.Exit(0))
  .Configure(config =>
  {
      config.Selector = "--> ";
      config.EnableFilter = false;
      config.Title = "Welcome to the Bank appliacation\nChoose from options below";
      config.EnableWriteTitle = false;
      config.EnableBreadcrumb = true;
  });

menu.Show();