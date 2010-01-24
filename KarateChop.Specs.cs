using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;

namespace KarateChop
{
  [Subject( "Karate Chop" )]
  public class when_array_is_null_or_empty
  {
    It should_return_negative_one = () =>
    {
      KarateChop.Find( 0, null ).ShouldEqual( -1 );
      KarateChop.Find( 0, new int[] {} ).ShouldEqual( -1 );
    };
  }

  [Subject( "Karate Chop" )]
  public class when_array_has_one_item
  {
    It should_return_zero_if_item_matchs = () =>
    {
      KarateChop.Find( 0, new int[] { 0 } ).ShouldEqual( 0 );
    };
    
    It should_return_negative_one_if_item_does_not_match = () =>
    {
      KarateChop.Find( 0, new int[] { 1 } ).ShouldEqual( -1 );
    };
  }

  [Subject( "Karate Chop" )]
  public class when_array_has_odd_number_of_items
  {
    static int[] small = new int[] { 0, 1, 2 };
    static int[] large = new int[] { 0, 1, 2, 3, 4 };

    It should_return_negative_one_if_no_items_match = () =>
    {
      KarateChop.Find( 5, small ).ShouldEqual( -1 );
      KarateChop.Find( 5, large ).ShouldEqual( -1 );
    };
    
    It should_find_item_in_middle = () =>
    {
      KarateChop.Find( 1, small ).ShouldEqual( 1 );
      KarateChop.Find( 2, large ).ShouldEqual( 2 );
    };
    
    It should_find_item_in_first_half = () =>
    {
      KarateChop.Find( 0, small ).ShouldEqual( 0 );
      KarateChop.Find( 1, large ).ShouldEqual( 1 );
    };
    
    It should_find_item_in_second_half = () =>
    {
      KarateChop.Find( 2, small ).ShouldEqual( 2 );
      KarateChop.Find( 3, large ).ShouldEqual( 3 );
    };

    It should_find_item_when_first = () =>
    {
      KarateChop.Find( 0, small ).ShouldEqual( 0 );
      KarateChop.Find( 0, large ).ShouldEqual( 0 );
    };

    It should_find_item_when_last = () =>
    {
      KarateChop.Find( 2, small ).ShouldEqual( 2 );
      KarateChop.Find( 4, large ).ShouldEqual( 4 );
    };
  }

  [Subject( "Karate Chop" )]
  public class when_array_has_even_number_of_items
  {
    static int[] small = new int[] { 0, 1, 2, 3 };
    static int[] large = new int[] { 0, 1, 2, 3, 4, 5 };

    It should_return_negative_one_if_no_items_match = () =>
    {
      KarateChop.Find( 6, small ).ShouldEqual( -1 );
      KarateChop.Find( 6, large ).ShouldEqual( -1 );
    };
    
    It should_find_item_in_middle = () =>
    {
      KarateChop.Find( 1, small ).ShouldEqual( 1 );
      KarateChop.Find( 2, small ).ShouldEqual( 2 );

      KarateChop.Find( 2, large ).ShouldEqual( 2 );
      KarateChop.Find( 3, large ).ShouldEqual( 3 );
    };
    
    It should_find_item_in_first_half = () =>
    {
      KarateChop.Find( 1, small ).ShouldEqual( 1 );
      KarateChop.Find( 1, large ).ShouldEqual( 1 );
    };
    
    It should_find_item_in_second_half = () =>
    {
      KarateChop.Find( 2, small ).ShouldEqual( 2 );
      KarateChop.Find( 4, large ).ShouldEqual( 4 );
    };

    It should_find_item_when_first = () =>
    {
      KarateChop.Find( 0, small ).ShouldEqual( 0 );
      KarateChop.Find( 0, large ).ShouldEqual( 0 );
    };

    It should_find_item_when_last = () =>
    {
      KarateChop.Find( 3, small ).ShouldEqual( 3 );
      KarateChop.Find( 5, large ).ShouldEqual( 5 );
    };
  }
}
