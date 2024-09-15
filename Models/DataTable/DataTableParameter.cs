namespace DataTableTest.Models.DataTable
{
    public class DataTableParameter
    {
        public int draw { get; set; }
        public List<DataTableColumns> columns { get; set; }
        public List<DataTableOrder> order { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        public DataTableSearch search { get; set; }
    }

    public class DataTableColumns
    {
        public string data { get; set; }
        public object name { get; set; }
        public bool searchable { get; set; }
        public bool orderable { get; set; }
        public DataTableSearch search { get; set; }
    }

    public class DataTableSearch
    {
        public string value { get; set; }
        public string regex { get; set; }
    }

    public class DataTableOrder
    {
        public string column { get; set; }
        public string dir { get; set; }
        public string name { get; set; }
    }
}
