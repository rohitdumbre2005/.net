using Entities;
using OrderProcessing.Repository;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

OrderRepository repo=new OrderRepository();

app.MapGet("/api/orders",()=>{return repo.GetAllOrders();});

app.MapGet("/api/orders/{id}",(int id)=>{
        return repo.GetOrderById(id);
});

app.MapPost("/api/orders",( Order order)=>{
        repo.Create(order);
        return "Order added";
});  

app.MapPut("/api/orders/{id}",( Order order)=>{ 
    repo.Update(order);
    return "Order updated";
});      

app.MapDelete("/api/orders/{id}",(int id)=>{
    repo.Delete(id);
    return "Order Deleted";
});      

app.Run();