//#define ASTARDEBUG   //"BBTree Debug" If enables, some queries to the tree will show debug lines. Turn off multithreading when using this since DrawLine calls cannot be called from a different thread

using System;
using UnityEngine;
using Pathfinding;
using System.Collections.Generic;

namespace Pathfinding {
	/** Axis Aligned Bounding Box Tree.
	 * Holds a bounding box tree of triangles.\n
	 * \b Performance: Insertion - Average O(log(n)) - About 0.003 ms for normal loads
	 * \astarpro
	 */
	public class BBTree {

		public void OnDrawGizmos () {}
	}
	
}