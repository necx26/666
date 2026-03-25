using System.Windows.Media;

namespace StockAI
{
    public class StockModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Change { get; set; }
        public string Market { get; set; }

        // 自动计算颜色：涨红跌绿 (赛博风格)
        public Brush TrendColor => Change.Contains("-")
            ? new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00F5D4")) // 极光绿
            : new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF3366")); // 霓虹红
    }
}