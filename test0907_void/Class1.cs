using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0907_void {


    public class test {
        public void function1(int a) {
            a += 101;
        }
        public void function2(ref int a) {
            a += 202;
        }
    }
    class Class1 {

        static void Main(string[] args) {
            int a = 0;
            test CTest = new test();
            CTest.function2(ref a);
            CTest.function1(a);
            MessageBox.Show(a.ToString());
        }
    }
}
