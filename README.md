# So this is an asp.net lab where we make an mvc project. Below is a copy of the requirements provided by my professor

[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/uz-6UAyj)
# Tri-C IT 2030 – ASP.NET

## Lab 6 – Building Razor Views and Pages

### Description and Instructions

In this lab, you create your own ASP.NET project to understand how Razor views are used. You will use Razor syntax to create content, apply routing, pass data between controllers and views, and use Razor layouts and view components. This is the first lab where you will submit your own project, so please make sure all project files are included in your submission.

- **Setup:**
  - Create a new ASP.NET Core web application with MVC and Razor pages enabled
  - Start a new project that includes a controller, model, and view structure
- **Part 1:** Set Up a Model
  - Add a class called Product in the Models folder with the following properties
    - Id (int)
    - Name (string)
    - Price (decimal)
    - InStock (bool)
- **Part 2:** Add Sample Data
  - In your controller, create an action that returns a list of products. Use the following code snippet:
```
public IActionResult ProductList()
{
    var products = new List<Product>
    {
        new Product { Id = 1, Name = "Laptop", Price = 999.99M, InStock = true },
        new Product { Id = 2, Name = "Headphones", Price = 149.99M, InStock = false },
        new Product { Id = 3, Name = "Mouse", Price = 49.99M, InStock = true }
    };
    ViewBag.ProductCount = products.Count;
    return View(products);
}
```
- **Part 3:** Create a Razor View
  - In ProductList.cshtml, add code to display each product’s information by using @model, @foreach, and @if
    - Use @foreach to iterate through each product in the model, displaying the Name and Price
    - Use @if to show the words "In Stock" in green if the product is in stock and "Out of Stock" in red if the product is out of stock
  - At the top of the page, show the total products by displaying the ProductCount from the ViewBag
- **Part 4:** Using _Layout
  - In the _Layout.cshtml file, add a title that will be shown on each page at the top and a footer with a fake company address and contact email address

### Rubric

Your code will be graded using the following rubric

| Assignment Part    | Points Possible    | Excellent     | Average     | Poor    | No Score    |
| ------------------ | ------------------ | ------------- | ----------- | ------- | ----------- |
| Part 1             | 7                  | 7             | 4           | 1       | 0           |
| Part 2             | 7                  | 7             | 4           | 1       | 0           |
| Part 3             | 9                  | 9             | 5           | 2       | 0           |
| Part 4             | 7                  | 7             | 4           | 1       | 0           |

The terms in the rubric are defined as:

- **Excellent:** Code works as described in the description AND all comments and instructions in the description are addressed AND code compiles without errors.
- **Average:** Code works somewhat as described in the description AND most comments and instructions in the description are addressed AND code compiles without errors or with errors that do not prevent the code from running.
- **Poor:** Code does not adequately address the instructions OR is poorly written OR has significant errors that prevent complete grading.
- **No Score:** Code did not compile OR does not address instructions OR code turned in late OR code not turned in OR code not turned in via GitHub (unless professor gives permission)
