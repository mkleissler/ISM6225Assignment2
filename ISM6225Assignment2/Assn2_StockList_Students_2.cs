using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
  public partial class StockList
  {
    //param   (StockList)listToMerge : second list to be merged 
    //summary      : merge two different list into a single result list
    //return       : merged list
    //return type  : StockList
    public StockList MergeList(StockList listToMerge)
    {
      StockList resultList = new StockList();

            // write your implementation here
            
            StockNode current = this.head;
            StockNode previous = this.head;
            while (current != null)
            {
                Stock currentStock = current.StockHolding;
                resultList.AddStock(currentStock);
                previous = current;
                current = current.Next;
            }

      return resultList;
    }

    //param        : NA
    //summary      : finds the stock with most number of holdings
    //return       : stock with most shares
    //return type  : Stock
    public Stock MostShares()
    {
      Stock mostShareStock = null;

            // write your implementation here

            StockNode current = this.head;
            StockNode previous = this.head;
            Stock currentStock = current.StockHolding;
            mostShareStock = currentStock;
            while (current != null)
            {
                if (currentStock.Holdings > mostShareStock.Holdings)
                    {
                        mostShareStock = currentStock;
                    }
                previous = current;
                current = current.Next;
            }

            return mostShareStock;
    }

    //param        : NA
    //summary      : finds the number of nodes present in the list
    //return       : length of list
    //return type  : int
    public int Length()
    {
      int length = 0;

            // write your implementation here
           
            var current = this.head;
            while(current != null)
            {
                length++;
                current = current.Next;
            }

      return length;
    }
  }
}