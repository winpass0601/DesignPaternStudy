using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Aggregate<T> {
	Iterator<T> GetIterator();
}
