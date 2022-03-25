using System.Linq;
using System.Text;
using AlgoSdk;
using Cysharp.Threading.Tasks;
using NUnit.Framework;
using UnityEngine;

[TestFixture]
public abstract class AlgodClientTestFixture : KmdClientTestFixture
{
    protected override AlgoServices RequiresServices => AlgoServices.Algod | base.RequiresServices;

    protected override async UniTask TearDownAsync()
    {
        var response = await AlgoApiClientSettings.Algod.GetPendingTransactionsByAccount(PublicKey);
        while (response.Payload.TopTransactions != null && response.Payload.TopTransactions.Length > 0)
        {
            Debug.Log($"Waiting for pending transactions:\n{JsonUtility.ToJson(response.Payload, true)}");
            await UniTask.Delay(100);
            response = await AlgoApiClientSettings.Algod.GetPendingTransactionsByAccount(PublicKey);
        }
        await base.TearDownAsync();
    }

    protected static async UniTask<Address[]> GetAddresses()
    {
        var genesisResponse = await AlgoApiClientSettings.Algod.GetGenesisInformation();
        var genesisInfo = JsonUtility.FromJson<GenesisInformation>(Encoding.UTF8.GetString(genesisResponse.Payload.Json));
        return genesisInfo.alloc
            .Where(a => a.comment.Contains("Wallet"))
            .Select(a => (Address)a.addr)
            .ToArray();
    }
}
