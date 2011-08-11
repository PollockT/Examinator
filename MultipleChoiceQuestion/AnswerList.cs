using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace Examinator {
    public class AnswerList<T> : BindingList<T>{

        public AnswerList() {
        }

        public AnswerList(AnswerList<T> list){
            foreach(T item in list){
                this.Add(item);
            }
        }

        public bool MoveUp(int loc) {
            if (loc > 0 && loc <= this.Count - 1) {
                T tmp = this[loc];
                this.RemoveAt(loc);
                this.Insert(loc - 1, tmp);
                return true;
            }
            return false;
        }

        public bool MoveDown(int loc) {
            if(loc >= 0 && loc < this.Count - 1){
                T tmp = this[loc];
                this.RemoveAt(loc);
                this.Insert(loc + 1, tmp);
                return true;
            }
            return false;
        }
    }
}
