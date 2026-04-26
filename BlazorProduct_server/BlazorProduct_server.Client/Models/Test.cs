namespace BlazorProduct_server.Client.Models
{
    public class Test
    {
        public int TestId { get; set; }

        public string? Name { get; set; }

        public bool Status { get; set; }

        public IEnumerable<TestProps> TestPropetries { get; set; }
    }
}
