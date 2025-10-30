namespace SmartInventory.DataTransferObjects
{
    public class UnitOfMeasurementUpdateModel : BaseModel
    {
        public string UnitCode { get; set; } = string.Empty;
        public string UnitName { get; set; } = string.Empty;
    }
}
