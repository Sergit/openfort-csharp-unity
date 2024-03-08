![Openfort Protocol][banner-image]

<div align="center">
  <h4>
    <a href="https://www.openfort.xyz/">
      Website
    </a>
    <span> | </span>
    <a href="https://www.openfort.xyz/docs">
      Documentation
    </a>
    <span> | </span>
    <a href="https://www.openfort.xyz/docs/reference/api/authentication">
      API Docs
    </a>
    <span> | </span>
    <a href="https://twitter.com/openfortxyz">
      Twitter
    </a>
  </h4>
</div>

[banner-image]: https://blog-cms.openfort.xyz/uploads/1_38e40747b6.png

# Openfort Unity SDK

## Installation (Unity Package Manager)

**Option 1 - File System**

Open `Packages/manifest.json` and add these lines:

```
"com.openfort.sdk": "https://github.com/openfort-xyz/openfort-csharp-unity.git",
"com.unity.nuget.newtonsoft-json": "3.0.1",
"com.cysharp.unitask": "https://github.com/Cysharp/UniTask.git?path=src/UniTask/Assets/Plugins/UniTask#2.3.3"
```

**Option 2 - Editor UI**

Follow this instructions:

https://docs.unity3d.com/Manual/upm-ui-giturl.html

And add these urls:

`https://github.com/Cysharp/UniTask.git?path=src/UniTask/Assets/Plugins/UniTask#2.3.3`

`https://github.com/needle-mirror/com.unity.nuget.newtonsoft-json.git`

`https://github.com/openfort-xyz/openfort-csharp-unity.git`

## Usage

With the Openfort Unity SDK, you can sign transaction intents using one of four methods or signers:
```csharp
var sdk = new Openfort("pk_test_XXXXXXX");
```

### 1. Session Signer
The Session Signer allows you to use an external signing keys, without needing to provide it every time. Here's how to use it:

- **Configure the Session Key**: Call `ConfigureSessionKey()`. This method returns a public key and a boolean indicating whether you need to register the key from the backend.
```csharp
var sessionKey = sdk.ConfigureSessionKey();
```
- **Register Key and Send Signature Session Request**: If the `sessionKey.IsRegistered` boolean is true, register the key from the backend. Refer to the documentation for session management [here](https://www.openfort.xyz/docs/guides/accounts/sessions).
- **Send Signature Transaction Intent Request**: When calling SendSignatureTransactionIntentRequest, pass the transaction intent ID and the user operation. The session signer will handle the signing.

### 2. External Sign

This method allows you to externally sign transactions without logging in or additional configurations:

- **Call SendSignatureTransactionIntentRequest**: Simply pass the transaction intent ID and the pre-generated signature.
```csharp
var response = await sdk.SendSignatureTransactionIntentRequest("transaction_intent_id", signature: "your_signature");
```

### 3. Custodial Sign
In this method, Openfort takes responsibility for handling signatures, and when you start the transaction intent from the backend, Openfort will handle the signing and you dont need to cal the `SendSignatureTransactionIntentRequest` method.

### 4. Embedded Signer
The Embedded Signer uses key splitting methods to manage the private key on the client side:
- **Login and Configure the Embedded Signer**: First, ensure the user is logged in, using `LoginWithEmailPassword`, `LoginWithOAuth` or if not registred `SignUp`. Then call `ConfigureEmbeddedSigner`. If a `MissingRecoveryMethod` exception is thrown, it indicates there's no share on the device and you have to call `ConfigureEmbeddedRecovery` to provide a recovery method.
```csharp
try
{
    mOpenfort.ConfigureEmbeddedSigner(chainId);
}
catch (MissingRecoveryMethod)
{
    await mOpenfort.ConfigureEmbeddedRecovery(new PasswordRecovery("user_password"));
}
```
For now the only recovery method available is the `PasswordRecovery` method.
- **Send Signature Transaction Intent Request**: Similar to the session signer, pass the transaction intent ID and the user operation. The embedded signer reconstructs the key and signs the transaction.
```csharp
var response = await sdk.SendSignatureTransactionIntentRequest("transaction_intent_id", "user_op");
```

## Support
The Unity SDK is a work in progress. For support, [open an issue](https://github.com/openfort-xyz/openfort-csharp-unity/issues).

## Example

For a working example using the Openfort Unity SDK, please refer to [Lost Dungeon repository](https://github.com/openfort-xyz/lost-dungeon)
