namespace Ecommerce.Models.Cms
{
    public partial class WidgetSettings
    {
        public WidgetSettings()
        {
            ActiveWidgetSystemNames = new List<string>();
        }
        public List<string> ActiveWidgetSystemNames { get; set; }
    }
}