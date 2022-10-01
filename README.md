# Domain-Driven-Desing-Patent
.Net Core 5 - Domain Drive Desing Patent


## Table of contents
* [General info](#general-info)
* [Screenshots](#screenshots)
* [Projects](#Projects)
* [Code Examples](#code-examples)

## General info
In this project, I write both theoretical and practical details about Domain-Driven Design, a technique that has been used frequently in the modern software development world.


## Screenshots
![Example screenshot](screenshot.jpg)


## Projects
- .Net Core 5
- MediatR
- Domain Driven Desing


## Code Examples
Show examples of usage:
```
public class OrderStartedDomainEvent : INotification
    {
        public string UserName { get; set; }
        

        public AggregateModels.OrderModels.Order Order { get; set; }

        public OrderStartedDomainEvent(string userName, AggregateModels.OrderModels.Order order)
        {
            UserName = userName ;
            Order = order ?? throw new ArgumentNullException(nameof(order));
        }
    }

```
