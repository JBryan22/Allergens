using System.Collections.Generic;
using System;

namespace Allergens.Models
{
    public class Allergy
    {
      private int _allergyScore;
      private List<string> _allergyList;
      private List<string> _allergenList;

      public Allergy(int allergyScore)
      {
        _allergyScore = allergyScore;
        _allergyList = new List<string>{};
        _allergenList = new List<string> {"eggs", "peanuts", "shellfish", "strawberries", "tomatoes", "chocolate", "pollen", "cats"};

      }

      public List<string> GetAllergies()
      {
        int number = _allergyScore;
        List<int> binaryNumber = new List<int>{};

        while(number >= 1)
        {
          binaryNumber.Add(number % 2);
          number /= 2;
        }

        for (int i = 0; i < binaryNumber.Count; i++)
        {
          if (binaryNumber[i] == 1)
          {
            _allergyList.Add(_allergenList[i]);
          }
        }

        return _allergyList;
      }

    }
}


//newNumArr.push(hexNums[(number % 2)])
//      number = parseInt(number / 2);
