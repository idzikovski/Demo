using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace ComparisonProject
{
    public class MultipleCircleViewModel
    {
        public ObservableCollection<MultipleCircleModel> DoughnutSeriesData { get; set; }

        public MultipleCircleViewModel()
        {
            DoughnutSeriesData = new ObservableCollection<MultipleCircleModel>
            {
                new MultipleCircleModel("Vehicle", 62.7,"ToyCar.png"),
                new MultipleCircleModel("Education",29.5,"Chart_Book.png"),
                new MultipleCircleModel("Home", 85.2, "HouseIcon.png"),
                new MultipleCircleModel("Personal", 45.6,"Savings.png"),
                new MultipleCircleModel("Work",29.5,"Chart_Book.png"),
                new MultipleCircleModel("Food", 45.6,"Savings.png"),
                new MultipleCircleModel("Education",29.5,"Chart_Book.png"),
            };
        }

    }

    public class MultipleCircleModel
    {
        public string XValue
        {
            get;
            set;
        }

        public double YValue
        {
            get;
            set;
        }

        public string Image
        {
            get;
            set;
        }

        public MultipleCircleModel(string xValue, double yValue, string image)
        {
            XValue = xValue;
            YValue = yValue;
            Image = image;
        }
    }
}
