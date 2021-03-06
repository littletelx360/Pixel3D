﻿// Copyright © Conatus Creative, Inc. All rights reserved.
// Licensed under the Apache 2.0 License. See LICENSE.md in the project root for license terms.
using System.IO;
using Microsoft.Xna.Framework;

namespace Pixel3D.Extensions
{
	public static class PositionExtensions
	{
		public static void Write(this BinaryWriter bw, Position position)
		{
			position.Serialize(bw);
		}

		public static Position ReadPosition(this BinaryReader br)
		{
			return new Position(br);
		}

		public static Point GetXY(this Position position)
		{
			return new Point(position.X, position.Y);
		}

		public static Point GetXZ(this Position position)
		{
			return new Point(position.X, position.Z);
		}

		/// <summary>Project the point onto the XY plane at depth Z = 0</summary>
		public static Point ToWorldZero(this Position position)
		{
			return new Point(position.X, position.Y + position.Z);
		}

		/// <summary>Project the point onto the XY plane at depth Z = 0, where Y- is up. (Suitable for passing to a SpriteBatch with an appropriate transform.)</summary>
		public static Vector2 ToDisplay(this Position position)
		{
			return new Vector2(position.X, -(position.Y + position.Z));
		}
	}
}