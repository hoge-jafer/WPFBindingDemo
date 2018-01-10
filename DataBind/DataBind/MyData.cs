using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBind
{
    public class MyData : INotifyPropertyChanged
    {
        private DateTime TheDates;
        //声明事件
        public event PropertyChangedEventHandler PropertyChanged;
        public MyData()
        {
            TheDates = DateTime.Now;
        }
        //把现在的时间拿到
        public DateTime TheDate
        {
            get { return TheDates; }
            set {
                TheDates = value;
                OnPropertyChanged("");
            }
        }
        private void OnPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(info));
        }
    }
}
