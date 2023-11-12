using Codility_GenomicRangeQuery;

namespace Codility_GenomicRangeQueryTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestExample()
        {
            // Arrange
            string S = "CAGCCTA";
            int[] P = { 2, 5, 0 };
            int[] Q = { 4, 5, 6 };
            Solution solution = new Solution();

            // Act
            int[] result = solution.solution(S, P, Q);

            // Assert
            Assert.Equal(new[] { 2, 4, 1 }, result);
        }

        [Fact]
        public void TestAllSameNucleotide()
        {
            // Arrange
            string S = "GGGGG";
            int[] P = { 0, 1, 2, 3, 4 };
            int[] Q = { 0, 1, 2, 3, 4 };
            Solution solution = new Solution();

            // Act
            int[] result = solution.solution(S, P, Q);

            // Assert
            Assert.Equal(new[] { 3, 3, 3, 3, 3 }, result);
        }

        [Fact]
        public void TestNoOccurrences()
        {
            // Arrange
            string S = "ATATAT";
            int[] P = { 0, 1, 2, 3, 4, 5 };
            int[] Q = { 0, 1, 2, 3, 4, 5 };
            Solution solution = new Solution();

            // Act
            int[] result = solution.solution(S, P, Q);

            // Assert
            Assert.Equal(new[] { 1, 4, 1, 4, 1, 4 }, result);
        }     
    }
}