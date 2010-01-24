using System;

namespace KarateChop
{
  public class KarateChop
  {
    public static int Find( int target, int[] array )
    {
      if ( array == null || array.Length == 0 ) return -1;
      if ( array.Length == 1 && array[0] == target ) return 0;

      return FindWorker( 0, array.Length - 1, target, array );
    }

    static int FindWorker( int startIndex, int endIndex, int target, int[] array )
    {
      if ( endIndex - startIndex <= 1 )
      {
        if ( array[startIndex] == target ) return startIndex;
        else if ( array[endIndex] == target ) return endIndex;
        else return -1;
      }

      int half = ( ( endIndex - startIndex ) / 2 ) + startIndex;
      
      if ( array[half] == target ) return half;
      if ( array[half] > target ) return FindWorker( startIndex, half, target, array );
      else return FindWorker( half, endIndex, target, array );
    }
  }
}
