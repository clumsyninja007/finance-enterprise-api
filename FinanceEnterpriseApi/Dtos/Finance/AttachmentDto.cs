namespace FinanceEnterpriseApi.Dtos.Finance
{
    public class AttachmentDto
    {
        public int DocId { get; set; }
        public string AttachId { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string FieldValue { get; set; }
    }
}
