using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Iterator<T> {
	void SeekBegin();
	bool HasNext();
	T Next();
}
