//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using UnityCollections = Unity.Collections;


namespace Algorand.Unity
{
    
    
    public partial struct SignedTxn
    {
        
        private static bool @__generated__IsValid = SignedTxn.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            Algorand.Unity.AlgoApiFormatterLookup.Add<Algorand.Unity.SignedTxn>(new Algorand.Unity.AlgoApiObjectFormatter<Algorand.Unity.SignedTxn>(false).Assign("sig", (Algorand.Unity.SignedTxn x) => x.Sig, (ref Algorand.Unity.SignedTxn x, Algorand.Unity.Sig value) => x.Sig = value).Assign("msig", (Algorand.Unity.SignedTxn x) => x.Msig, (ref Algorand.Unity.SignedTxn x, Algorand.Unity.MultisigSig value) => x.Msig = value).Assign("lsig", (Algorand.Unity.SignedTxn x) => x.Lsig, (ref Algorand.Unity.SignedTxn x, Algorand.Unity.LogicSig value) => x.Lsig = value).Assign("txn", (Algorand.Unity.SignedTxn x) => x.Txn, (ref Algorand.Unity.SignedTxn x, Algorand.Unity.Transaction value) => x.Txn = value).Assign("sgnr", (Algorand.Unity.SignedTxn x) => x.AuthAddr, (ref Algorand.Unity.SignedTxn x, Algorand.Unity.Address value) => x.AuthAddr = value));
            return true;
        }
    }
    
    public partial struct SignedTxn<TTxn>
    {
        
        private static bool @__generated__IsValid = SignedTxn<TTxn>.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            Algorand.Unity.AlgoApiFormatterLookup.Add<Algorand.Unity.SignedTxn<TTxn>>(new Algorand.Unity.AlgoApiObjectFormatter<Algorand.Unity.SignedTxn<TTxn>>(false).Assign("sig", (Algorand.Unity.SignedTxn<TTxn> x) => x.Sig, (ref Algorand.Unity.SignedTxn<TTxn> x, Algorand.Unity.Sig value) => x.Sig = value).Assign("msig", (Algorand.Unity.SignedTxn<TTxn> x) => x.Msig, (ref Algorand.Unity.SignedTxn<TTxn> x, Algorand.Unity.MultisigSig value) => x.Msig = value).Assign("lsig", (Algorand.Unity.SignedTxn<TTxn> x) => x.Lsig, (ref Algorand.Unity.SignedTxn<TTxn> x, Algorand.Unity.LogicSig value) => x.Lsig = value).Assign("txn", (Algorand.Unity.SignedTxn<TTxn> x) => x.Txn, (ref Algorand.Unity.SignedTxn<TTxn> x, TTxn value) => x.Txn = value).Assign("sgnr", (Algorand.Unity.SignedTxn<TTxn> x) => x.AuthAddr, (ref Algorand.Unity.SignedTxn<TTxn> x, Algorand.Unity.Address value) => x.AuthAddr = value));
            return true;
        }
    }
}
