/*
 * Created by Ranorex
 * User: ykhan
 * Date: 5/12/2017
 * Time: 4:10 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace IntegrityService.Main.Login.TestCase
{
	/// <summary>
	/// Description of xyz.
	/// </summary>
	public struct xyz : IEquatable<xyz>
	{
		int member; // this is just an example member, replace it with your own struct members!
		
		#region Equals and GetHashCode implementation
		// The code in this region is useful if you want to use this structure in collections.
		// If you don't need it, you can just remove the region and the ": IEquatable<xyz>" declaration.
		
		public override bool Equals(object obj)
		{
			if (obj is xyz)
				return Equals((xyz)obj); // use Equals method below
			else
				return false;
		}
		
		public bool Equals(xyz other)
		{
			// add comparisions for all members here
			return this.member == other.member;
		}
		
		public override int GetHashCode()
		{
			// combine the hash codes of all members here (e.g. with XOR operator ^)
			return member.GetHashCode();
		}
		
		public static bool operator ==(xyz left, xyz right)
		{
			return left.Equals(right);
		}
		
		public static bool operator !=(xyz left, xyz right)
		{
			return !left.Equals(right);
		}
		#endregion
	}
}
