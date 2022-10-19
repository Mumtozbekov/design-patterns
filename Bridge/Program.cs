using Bridge.Pages;
using Bridge.Themes;

var darkTheme = new DarkTheme();
var lightTheme = new LightTheme();

var about = new About(darkTheme);
var careers = new Careers(lightTheme);

Console.WriteLine(about.GetContent()); //Output: About page in Dark Black
Console.WriteLine(careers.GetContent()); //Output: Careers page in Off White