using RimWorld.Planet;
using Verse;

namespace PrepareLanding.Core.Extensions
{
    public static class TileExtensions
    {
        /// <summary>
        ///     Given a <see cref="Tile" /> instance returns its index in the world grid.
        /// </summary>
        /// <param name="tile">The tile for which to return the index.</param>
        /// <returns>
        ///     An integer representing the tile index in the world grid or -1 if the tile is not found (or if the world grid
        ///     is not initialized).
        /// </returns>
        public static int TileId(this Tile tile)
        {
            if (Find.World?.grid == null || tile == null)
                return PlanetTile.Invalid;

            for (int i = 0; i < Find.World.grid.TilesCount; i++)
            {
                if (Find.World.grid[i] == tile)
                    return i;
            }
            return PlanetTile.Invalid;
        }
    }
}