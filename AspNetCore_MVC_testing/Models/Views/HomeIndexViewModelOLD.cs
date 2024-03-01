using AspNetCore_MVC_testing.Models.Components;
using AspNetCore_MVC_testing.Models.Sections;
using System.Threading.Tasks;

namespace AspNetCore_MVC_testing.Models.Views;

public class HomeIndexViewModelOLD
{
    public string Title { get; set; } = "Welcome to silikon website";
    public ShowcaseViewModel Showcase { get; set; } = new ShowcaseViewModel
    {
        Id = "overview",
        ShowcaseImage = new() { ImageUrl = "Images/showcase-image.svg", AltText = "Showcase image" },
        Title = "Task Management Assistant You Gonna Love",
        Text = "We offer you a new generation of task management system. Plan, manage & track all your tasks in one flexible tool.",
        Link = new() { ControllerName = "Downloads", ActionName = "Index", Text = "Get started for free" },
        BrandsText = "Largest companies use our tool to work efficiently",

        Brands =
                [
                    new() { ImageUrl = "Images/logo-1.svg", AltText = "Brand name 1" },
                    new() { ImageUrl = "Images/logo-2.svg", AltText = "Brand name 2" },
                    new() { ImageUrl = "Images/logo-3.svg", AltText = "Brand name 3" },
                    new() { ImageUrl = "Images/logo-4.svg", AltText = "Brand name 4" },
                ]



    };

    public FeaturesViewModel Features { get; set; } = new FeaturesViewModel
    {
        Id = "features",
        Title = "What Do You Get with Our Tool?",
        Description = "Make sure all your tasks are organized so you can set the priorities and focus on important.",
        FeaturesBoxes = new List<FeaturesBoxViewModel>
    {
        new FeaturesBoxViewModel
        {
            Id = "1",
            Topic = "Comments on Tasks",
            Text = "Id mollis consectetur congue egestas egestas suspendisse blandit justo.",
            ClassNames = new List<string> { "link-box", "f-box", "f-box-1" },
            Link = new() {ControllerName =  "Home", ActionName = "Index"},
            Image = new() {ImageUrl = "/Images/icon-1.svg"}

        },

        new FeaturesBoxViewModel
        {
            Id = "2",
            Topic = "Tasks Analytics",
            Text = "Non imperdiet facilisis nulla tellus Morbi scelerisque eget adipiscing vulputate.",
            ClassNames = new List<string> { "link-box", "f-box", "f-box-2" },
            Link = new() {ControllerName =  "Home", ActionName = "Index"},
            Image = new() {ImageUrl = "/Images/icon-2.svg"}
        },

        new FeaturesBoxViewModel
        {
            Id = "3",
            Topic = "Multiple Assignees",
            Text = "A elementum, imperdiet enim, pretium etiam facilisi in aenean quam mauris.",
            ClassNames = new List<string> { "link-box", "f-box", "f-box-3" },
            Link = new() {ControllerName =  "Home", ActionName = "Index"},
            Image = new() {ImageUrl = "/Images/icon-3.svg"}
        },

        new FeaturesBoxViewModel
        {
            Id = "4",
            Topic = "Notifications",
            Text = "Diam, suspendisse velit cras ac. Lobortis diam volutpat, eget pellentesque viverra.",
            ClassNames = new List<string> { "link-box", "f-box", "f-box-4" },
            Link = new() {ControllerName =  "Home", ActionName = "Index"},
            Image = new() {ImageUrl = "/Images/icon-4.svg"}
        },

        new FeaturesBoxViewModel
        {
            Id = "5",
            Topic = "Sections & Subtasks",
            Text = "Mi feugiat hac id in. Sit elit placerat lacus nibh lorem ridiculus lectus.",
            ClassNames = new List<string> { "link-box", "f-box", "f-box-5" },
            Link = new() {ControllerName =  "Home", ActionName = "Index"},
            Image = new() {ImageUrl = "/Images/icon-5.svg"}
        },

        new FeaturesBoxViewModel
        {
            Id = "6",
            Topic = "Data Security",
            Text = "Aliquam malesuada neque eget elit nulla vestibulum nunc cras.",
            ClassNames = new List<string> { "link-box", "f-box", "f-box-6" },
            Link = new() {ControllerName =  "Home", ActionName = "Index"},
            Image = new() {ImageUrl = "/Images/icon-6.svg"}
        },
    }
    };



}
