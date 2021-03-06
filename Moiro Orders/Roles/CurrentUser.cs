﻿using Moiro_Orders.Controller;
using Moiro_Orders.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Moiro_Orders.Roles
{
    class CurrentUser : IUser, IAdmin
    {
        public CurrentUser() { }

        #region Events
        //EVENTS
        public async Task<HttpStatusCode> CreateEvent(Event @event)
        {
            EventsController eventsController = new EventsController();
            var status = await eventsController.CreateEventAsync(@event);
            return status;
        }

        public async Task<List<Event>> GetEventsList(int count, int id)
        {
            EventsController eventsController = new EventsController();
            var events = await eventsController.GetAllEventsAsync(count, id);
            return events;
        }

        public async Task<List<Event>> GetEventsForStatistic(DateTime tmpDateStart, DateTime tmpDateEnd)
        {
            EventsController eventsController = new EventsController();
            var events = await eventsController.GetEventsForStatisticAsync(tmpDateStart, tmpDateEnd);
            return events;
        }

        public async Task<List<Event>> GetAllEventsToday(DateTime date)
        {
            EventsController eventsController = new EventsController();
            var events = await eventsController.GetAllEventsTodayAsync(date);
            return events;
        }

        public async Task<HttpStatusCode> EditEvent(Event @event)
        {
            EventsController eventsController = new EventsController();
            var status = await eventsController.UpdateEvetntAsync(@event);
            return status;
        }

        public async Task<HttpStatusCode> DeleteEvent(int id)
        {
            EventsController eventsController = new EventsController();
            var status = await eventsController.DeleteEvetntAsync(id);
            return status;
        }
        #endregion

        #region Orders
        //ORDERS
        public async Task<Order> GetOrderById(int id)
        {
            OrdersController ordersController = new OrdersController();
            var order = await ordersController.GetOrderAsync(id);
            return order;
        }

        public async Task<HttpStatusCode> CreateOrder(Order order)
        {
            OrdersController ordersController = new OrdersController();
            var status = await ordersController.CreateOrderAsync(order);
            return status;
        }

        public async Task<List<Order>> GetOrdersListOfDate(int userId, DateTime date)
        {
            OrdersController ordersController = new OrdersController();
            var orders = await ordersController.GetOrdersListOfDateAsync(userId, date);
            return orders;
        }

        public async Task<List<Order>> GetAllOrdersToday(DateTime date)
        {
            OrdersController ordersController = new OrdersController();
            var orders = await ordersController.GetAllOrdersTodayAsync(date);
            return orders;
        }

        public async Task<List<Order>> GetOrdersByStatus(int statusId, DateTime dateStart, DateTime dateEnd)
        {
            OrdersController ordersController = new OrdersController();
            var orders = await ordersController.GetOrdersByStatusAsync(statusId, dateStart, dateEnd);
            return orders;
        }

        public async Task<int> GetCountOrdersByStatus(int statusId)
        {
            OrdersController ordersController = new OrdersController();
            var ordersCount = await ordersController.GetCountOrdersByStatusAsync(statusId);
            return ordersCount;
        }

        public async Task<HttpStatusCode> DeleteOrder(int id)
        {
            OrdersController ordersController = new OrdersController();
            var status = await ordersController.DeleteOrderAsync(id);
            return status;
        }

        public async Task<HttpStatusCode> EditOrder(Order order)
        {
            OrdersController ordersController = new OrdersController();
            var status = await ordersController.UpdateOrderAsync(order);
            return status;
        }

        public async Task<List<Order>> GetNotConfirmedOrdersList(int userId, int statusId)
        {
            OrdersController ordersController = new OrdersController();
            var orders = await ordersController.GetNotConfirmedOrdersListAsync(userId, statusId);
            return orders;
        }

        public async Task<int> GetCountNotConfirmedOrders(int statusId, int userId)
        {
            OrdersController ordersController = new OrdersController();
            var ordersCount = await ordersController.GetCountNotConfirmedOrdersAsync(statusId, userId);
            return ordersCount;
        }

        #endregion

        #region PublicChat
        //PUBLIC CHAT
        public async Task<HttpStatusCode> CreatePublicChatMessage(PublicChat publicChat)
        {
            PublicChatsController publicChatsController = new PublicChatsController();
            var status = await publicChatsController.CreatePublicChatAsync(publicChat);
            return status;
        }

        public async Task<List<PublicChat>> GetPublicChatMessagesList(int count, int id)
        {
            PublicChatsController publicChatsController = new PublicChatsController();
            var publicChats = await publicChatsController.GetAllPublicChatsAsync(count, id);
            return publicChats;
        }

        public async Task<HttpStatusCode> DeletePublicChatMessage(int id)
        {
            PublicChatsController publicChatsController = new PublicChatsController();
            var status = await publicChatsController.DeletePublicChatAsync(id);
            return status;
        }

        public async Task<HttpStatusCode> EditPublicChatMessage(PublicChat publicChat)
        {
            PublicChatsController publicChatsController = new PublicChatsController();
            var status = await publicChatsController.UpdatePublicChatAsync(publicChat);
            return status;
        }
        #endregion

        #region Users
        //Users
        public List<User> GetNewADUsersList()
        {
            ActiveDyrectoryController activeDyrectoryController = new ActiveDyrectoryController();
            var users = activeDyrectoryController.GetNewADUsers();
            return users;
        }

        public async Task<List<User>> GetAllUserName()
        {
            UsersController usersController = new UsersController();
            var users = await usersController.GetAllUserNameAsync();
            return users;
        }

        public async Task<List<User>> GetAdminsList()
        {
            UsersController usersController = new UsersController();
            var users = await usersController.GetAdminsListAsync();
            return users;
        }

        public async Task<HttpStatusCode> UpdateUsersDb(User user)
        {
            UsersController usersController = new UsersController();
            var status = await usersController.UpdateUsersDbAsync(user);
            return status;
        }
        public async Task<HttpStatusCode> UpdateUser(User user)
        {
            UsersController usersController = new UsersController();
            var status = await usersController.UpdateUserAsync(user);
            return status;
        }

        #endregion

        #region Status
        //Status
        public async Task<List<Status>> GetStatuses()
        {
            StatusController statusController = new StatusController();
            var statuses = await statusController.GetStatusesListAsync();
            return statuses;
        }

        #endregion

        #region Webinar
        //Webinar

        public async Task<List<Webinar>> GetWebinarsListOfDate(int userId, DateTime date)
        {
            WebinarsController webinarsController = new WebinarsController();
            var webinars = await webinarsController.GetWebinarsListOfDateAsync(userId, date);
            return webinars;
        }

        public async Task<HttpStatusCode> CreateWebinar(Webinar webinar)
        {
            WebinarsController webinarsController = new WebinarsController();
            var status = await webinarsController.CreateWebinarAsync(webinar);
            return status;
        }

        public async Task<HttpStatusCode> EditWebinar(Webinar webinar)
        {
            WebinarsController webinarsController = new WebinarsController();
            var status = await webinarsController.UpdateWebinarAsync(webinar);
            return status;
        }

        public async Task<List<Webinar>> GetAllWebinarsToday(DateTime date)
        {
            WebinarsController webinarsController = new WebinarsController();
            var webinars = await webinarsController.GetAllWebinarsTodayAsync(date);
            return webinars;
        }

        

        #endregion
    }
}