using System.Runtime.CompilerServices;

namespace Codility_GenomicRangeQuery
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 1;
        public const int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int[] solution(string S, int[] P, int[] Q)
        {
            int N = S.Length;
            int M = P.Length;

            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE &&
                M >= RANGE_LOWEST_VALUE && M <= RANGE_HIGHEST_VALUE / 2) 
            {
                int[] result = new int[M];
                // Create prefix sums for each nucleotide type
                int[] prefixSumA = new int[N + 1];
                int[] prefixSumC = new int[N + 1];
                int[] prefixSumG = new int[N + 1];
                int[] prefixSumT = new int[N + 1];

                for (int i = 0; i < N; i++)
                {
                    prefixSumA[i + 1] = prefixSumA[i] + (S[i] == 'A' ? 1 : 0);
                    prefixSumC[i + 1] = prefixSumC[i] + (S[i] == 'C' ? 1 : 0);
                    prefixSumG[i + 1] = prefixSumG[i] + (S[i] == 'G' ? 1 : 0);
                    prefixSumT[i + 1] = prefixSumT[i] + (S[i] == 'T' ? 1 : 0);
                }

                // Process each query
                for (int i = 0; i < M; i++)
                {
                    int start = P[i];
                    int end = Q[i] + 1; // Add 1 to make the range inclusive
                                        // Check each nucleotide type in the range and find the minimum impact factor
                    if (prefixSumA[end] - prefixSumA[start] > 0)
                        result[i] = 1;
                    else if (prefixSumC[end] - prefixSumC[start] > 0)
                        result[i] = 2;
                    else if (prefixSumG[end] - prefixSumG[start] > 0)
                        result[i] = 3;
                    else
                        result[i] = 4;
                }

                return result;
            }
            
            return Array.Empty<int>();
        }
    }
}
