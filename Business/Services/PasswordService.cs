﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Services;

/// <summary>
/// Service cryptographique pour le hashage et la validation de mots de passe.
/// </summary>
/// <remarks>
/// </remarks>
public class PasswordService {
    // Paramètres de hashage.
    private const int saltSize = 16; // sel cryptographique de 128 bits
    private const int keySize = 32; // clé cryptographique de 256 bits
    private const int cryptographicIterations = 100000; // itérations de l'étirement de clé
    private const char hashSegmentDelimiter = ':'; // séparateur des sections générées - NE PAS CHANGER (sinon hashs existants invalidables)
    private static readonly HashAlgorithmName cryptographicAlgorithm = HashAlgorithmName.SHA256; // algorithme de base

    private static PasswordService? instance;

    private PasswordService() { }

    public static PasswordService GetInstance() {
        instance ??= new PasswordService();
        return instance;
    }


    /// <summary>
    /// Fonction de hachage de mot de passe.
    /// </summary>
    /// <remarks>
    /// Recoit le mot de passe en clair, non-encrypté, dans <paramref name="motDePasseNonEncrypte"/>.
    /// Retourne le mot de passe hashé sous forme de <see cref="string"/>.
    /// </remarks>
    /// <param name="motDePasseNonEncrypte">Le mot de passe en clair, non-encrypté.</param>
    /// <returns></returns>
    public string HashPassword(string motDePasseNonEncrypte) {
        byte[] salt = RandomNumberGenerator.GetBytes(saltSize);
        byte[] key = Rfc2898DeriveBytes.Pbkdf2(
            motDePasseNonEncrypte,
            salt,
            cryptographicIterations,
            cryptographicAlgorithm,
            keySize
        );
        return string.Join(
            hashSegmentDelimiter,
            Convert.ToHexString(key),
            Convert.ToHexString(salt),
            cryptographicIterations,
            cryptographicAlgorithm
        );
    }

    /// <summary>
    /// Fonction de validation de mots de passe.
    /// </summary>
    /// <remarks>
    /// Recoit le mot de passe en clair, non-encrypté, dans <paramref name="motDePasseNonEncrypte"/> tel qu'entré
    /// dans la fenêtre d'authentification (login) par l'utilisateur.<br/>
    /// Recoit le hash du mot de passe de l'utilisateur dans <paramref name="motDePasseNonEncrypte"/> tel que 
    /// trouvé pour l'utilisateur correspondant dans la base de données.<br/>
    /// Retourne <see langword="true"/> si le mot de passe en clair concorde (est valide), <see langword="false"/> sinon.
    /// </remarks>
    /// <param name="motDePasseNonEncrypte"></param>
    /// <param name="hashDuMotDePasseDansLaBdD"></param>
    /// <returns>True si le mot de passe est valide.</returns>
    public bool ValidatePassword(string motDePasseNonEncrypte, string hashDuMotDePasseDansLaBdD) {
        string[] segments = hashDuMotDePasseDansLaBdD.Split(hashSegmentDelimiter);
        byte[] key = Convert.FromHexString(segments[0]);
        byte[] salt = Convert.FromHexString(segments[1]);
        int iterations = int.Parse(segments[2]);
        HashAlgorithmName algorithm = new HashAlgorithmName(segments[3]);
        byte[] inputSecretKey = Rfc2898DeriveBytes.Pbkdf2(
            motDePasseNonEncrypte,
            salt,
            iterations,
            algorithm,
            key.Length
        );
        return key.SequenceEqual(inputSecretKey);
    }
}
