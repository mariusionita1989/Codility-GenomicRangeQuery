# Codility-GenomicRangeQuery
A DNA sequence can be represented as a string consisting of the letters A, C, G and T,</br>
which correspond to the types of successive nucleotides in the sequence.</br>
Each nucleotide has an impact factor, which is an integer.</br> 
Nucleotides of types A, C, G and T have impact factors of 1, 2, 3 and 4, respectively.</br> 
You are going to answer several queries of the form:</br> 
What is the minimal impact factor of nucleotides contained in a particular part of the given DNA sequence?</br>
The DNA sequence is given as a non-empty string S = S[0]S[1]...S[N-1] consisting of N characters.</br> 
There are M queries, which are given in non-empty arrays P and Q, each consisting of M integers.</br> 
The K-th query (0 ≤ K < M) requires you to find the minimal impact factor of nucleotides contained in the DNA sequence</br> 
between positions P[K] and Q[K] (inclusive).

For example, consider string S = CAGCCTA and arrays P, Q such that:</br>
P[0] = 2    Q[0] = 4</br>
P[1] = 5    Q[1] = 5</br>
P[2] = 0    Q[2] = 6</br>
The answers to these M = 3 queries are as follows:</br>
The part of the DNA between positions 2 and 4 contains nucleotides G and C (twice),</br> 
whose impact factors are 3 and 2 respectively, so the answer is 2.</br>
The part between positions 5 and 5 contains a single nucleotide T,</br> 
whose impact factor is 4, so the answer is 4.</br>
The part between positions 0 and 6 (the whole string) contains all nucleotides,</br> 
in particular nucleotide A whose impact factor is 1, so the answer is 1.</br>
Write a function:</br>
class Solution { public int[] solution(String S, int[] P, int[] Q); }</br>
that, given a non-empty string S consisting of N characters and two non-empty arrays P and Q consisting of M integers,</br> 
returns an array consisting of M integers specifying the consecutive answers to all queries.</br>
Result array should be returned as an array of integers.

For example, given the string S = CAGCCTA and arrays P, Q such that:</br>
P[0] = 2    Q[0] = 4</br>
P[1] = 5    Q[1] = 5</br>
P[2] = 0    Q[2] = 6</br>
the function should return the values [2, 4, 1], as explained above.

Write an efficient algorithm for the following assumptions:</br>
N is an integer within the range [1..100,000];</br>
M is an integer within the range [1..50,000];</br>
each element of arrays P and Q is an integer within the range [0..N - 1];</br>
P[K] ≤ Q[K], where 0 ≤ K < M;</br>
string S consists only of upper-case English letters A, C, G, T.
