// A tiny, unsorted stream of recent e-commerce transaction amounts.
class ChallengeDataset2
{
    public static readonly double[] RecentTransactions = {
        24.99, 5.50, 120.00, 45.15, 18.90, 310.50,
        12.00, 89.95, 7.50, 145.00, 64.99, 22.00
    };

    // Suggested Search Target: 89.95 (Expected Index: 7)
    // Expected Sorted Output: [5.5, 7.5, 12.0, 18.9, 22.0, 24.99, 45.15, 64.99, 89.95, 120.0, 145.0, 310.5]
}
