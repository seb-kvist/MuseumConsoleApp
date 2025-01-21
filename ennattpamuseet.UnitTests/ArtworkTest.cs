using System;
using System.Net.NetworkInformation;

namespace ennattpamuseet.UnitTests;
     public class ArtworkTest
    {
        [Fact]
        public void IncreasesArtworkCount()
        {
            // Arrange
            ArtworkStorage storage = new ArtworkStorage();
            int initialCount = storage.Artworks.Count;
            Artwork newArtwork = new Artwork("Magisk boll", "En boll full av magi och studs", "Toshi, 5 år");

            // Act
            storage.AddArtwork(newArtwork);

            // Assert
            Assert.Equal(initialCount + 1, storage.Artworks.Count);
            Assert.Contains(newArtwork, storage.Artworks);
        }
    }
