namespace Bike
{
    namespace Sale
    {
        class customers
        {
            public string customer_id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public int phone { get; set; }
            public string email { get; set; }
            public string street { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public int zip_code { get; set; }
        }

        enum OrderStatus { ORDERED, PACKED, OUT_OF_DELIVER, DELIVERED };
        class orders
        {
            public string order_id { get; set; }
            public string customer_id { get; set; }
            public OrderStatus order_status { get; set; }
            public DateTime order_date { get; set; }
            public DateTime required_date { get; set; }
            public DateTime shipped_date { get; set; }
            public string store_id { get; set; }
            public string staff_id { get; set; }
        }

        class staffs
        {
            public string staff_id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string email { get; set; }
            public int phone { get; set; }
            public bool active { get; set; }
            public string store_id { get; set; }
            public string manager_id { get; set; }
        }

        class stores
        {
            public string store_id { get; set; }
            public string store_name { get; set; }
            public int phone { get; set; }
            public string email { get; set; }
            public string street { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public int zip_code { get; set; }
        }

        class order_items
        {
            public string order_id { get; set; }
            public string item_id { get; set; }
            public string product_id { get; set; }
            public int quantity { get; set; }
            public double list_price { get; set; }
            public double discount { get; set; }
        }
    }

    namespace Production
    {
        class categories
        {
            public int category_id { get; set; }
            public string category_name { get; set; }
        }

        class brands
        {
            public int brand_id { get; set; }
            public string brand_name { get; set; }
        }

        class products
        {
            public int product_id { get; set; }
            public string product_name { get; set; }
            public int brand_id { get; set; }
            public int category_id { get; set; }
            public int model_year { get; set; }
            public decimal list_price { get; set; }
        }

        class stocks
        {
            public int store_id { get; set; }
            public int product_id { get; set; }
            public int quantity { get; set; }
        }
    }
}