﻿//======================================================================================================================
namespace hhlogic.streams {
//======================================================================================================================


//======================================================================================================================
// Entry Builder
// = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
public static class Entry
{
  public static Entry<K, V> build<K, V>(K key, V value)
  {
    Entry<K, V> p;
    p.key = key;
    p.value = value;
    return p;
  }
}
//======================================================================================================================


//======================================================================================================================
// A Key Value Pair
// = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
public struct Entry<K, V>
{
  public K key;
  public V value;
}
//======================================================================================================================


//======================================================================================================================
} // End Namespace
//======================================================================================================================
