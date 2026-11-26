using orderprocessing.models;
namespace OrderProcessing.Repository;

public class OrderRepository
{
    public List<Order> Stockorders = new List<Order>();
    public OrderRepository()
    {
        Stockorders.Add(new Order { orderid = 111, OrderDate =new DateTime(2026, 11, 19), Amount = 1500, customername = "Sanket katukar" });
        Stockorders.Add(new Order { orderid = 112, OrderDate =new DateTime(2026, 11, 20), Amount = 3000, customername = "Anish Bhaiyya" });
        Stockorders.Add(new Order { orderid = 113, OrderDate =new DateTime(2026, 11, 21), Amount = 6000, customername = "Roshan Patil" });
    }

    public List<Order> GetAllOrders()
    {
        return Stockorders;
    }

    public Order GetOrderById(int orderid)
    {
        List<Order> orders = GetAllOrders();
        Order theOrder = null;

        for(int i = 0; i < orders.Count; i++)
        {
            if(orders[i].orderid == orderid)
            {
                theOrder = orders[i];
                return theOrder;
            }
        }
        return theOrder;
    }

    public bool Create(Order theOrder)
    {
        bool status=false;
        this.Stockorders.Add(theOrder);
        status=true;
        return status;
    }

    public bool Update(Order orderToUpdate)
    {
        bool status = false;
        Order existingOrder = GetOrderById(orderToUpdate.orderid);
        if (existingOrder!= null)
        {
            existingOrder.OrderDate = orderToUpdate.OrderDate;
            status=true;
        }
        return status;
    }

    public bool Delete(int id){
        bool status=false;
        Order existingOrder=GetOrderById(id);
        if(existingOrder!=null){
           Stockorders.Remove(existingOrder);
           status=true;
        }
        return status;
    }

}
