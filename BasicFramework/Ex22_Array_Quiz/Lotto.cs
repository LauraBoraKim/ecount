using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex22_Array_Quiz
{

    class Lotto
    {
        private int[] numbers;
        private Random random;
       
        public Lotto() { //member field 초기화가 목적인 생성자에 처리 ...
            numbers = new int[6]; //배열의 초기화 (최초로 값을 가지는 것)
            random = new Random();  //초기화
        }

        public void getReadLottoNumbers() {
            for (int i = 0; i < 6; i++)
            {
                numbers[i] = random.Next(1, 46);
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        --i;
                        break;
                    }
                }
            }
        }

        public void displayLottoNumbers() {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
        }


        //추가적인 함수의 구현
        //private  함수


    }


}

/*
 static void Main(){
    Lotto lotto = new Lotto();
    lotto.getReadLottoNumbers();
    lotto.displayLottoNumbers();

    
  } 
 */
