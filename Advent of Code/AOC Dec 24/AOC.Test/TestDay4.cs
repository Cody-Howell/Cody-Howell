﻿using AOC.Lib.Day4;
using FluentAssertions;
namespace AOC.Test;

public class TestDay4 {
    private string vals = """"
        SMMMXMASMSSSMSMMSAMXSSMMSXMMAMXMXXXSMMSXXAMAASMSSMSSSMSASMMMXSXSMMSSSMSMXSXMAMAAXAXMMAMXMMMMSXSASMXMASAAMAMXMXAMAXMAXAXSAMSMXMMMAMAASASXMAMX
        SAMSAMXSAAAAXMASXXMAXAAAXMSMMMSSMMMXAAMMSMASMMMAMAAAAASASAXSAMXSXMAAMAAMAMASAMXSMMMSMAMASAMXAAAAMXAMXMAMSAMAMMAMXMXMASMAXMXAAMASAMMSMASAMSSM
        SAMMMMAMMMSMMMSMMMMMSSMMXXSAAMAAAMMXMMSAMMAMAAMASMXSMMMAMAXMASAXAMMSMXAMMMAMAMAAAAAMAASMSXSMMSMSMSSMMXAMSASXSAAMXSSXMXAMXSMSMSASAXSAMXMAMAAX
        MXMAXMXSAXAMXMMAMAAMXMASMASMMMSSMMSASAMASMASXMMAXAMXMXMAMXMAAMMSSMAXMMSASMSMAMXSSMSSSMSXSXXXAAXAMAAAXSAXSAMASMSXSMMXSMSXASAMXMMSMMSASASAMSSM
        SAXMMXAMMSMSAMXAMMASASAMMAMAXAAMMMSASASXMMMSASMXSASXXXXASASMXSASAMXSXXMAXAXSMSXMAMAAAAXXMASMSSSMMXSMMSMMMAMXMXMMAAAASAXMXSXMAMMXMAXAMXMAXXAA
        SMSSSMMSXAXMASXSMSASXSSXMSMXMMMMAAMMMAMMAMXSAMAXMASXMSSMSASAAMMSXMSXMXMSMSMAMSXSAMMMMMMAMXSXXAMXAAMAMSASMSAMXASMSMMXSAMMXMMSXSMSSSMSMASMMSSM
        XAAMASAAMMSSMMAAAMAMAXAXMAMXMSMSMSSXMAMMMXMMMMMMMAMAMAAXMAMXMXMXAXMAXSAMAAXSMSASMSSSXSXMAAXMMAMSMMMAMSAMAMXXMXXAMMMXMMMXAMAMXAAAAAAAMXMAAAXM
        MMMSAMXSAMAAAMMMMMSMMMMSMASAAAAAXAAXMSSSMAAAXAMAMAXAXXAXMXMXXAMSAMSAMXAMSMMXAMAMXMXAASMMMSSMMMMSASXSMMAMXMAMSSMMMASAMMSSMSAMSMMMSMSMXSSMMMSS
        XSAMXSAAMMSSMMXMAAAAAXXXMAMMSMSSSMMXAAAASASMSXSSSXSMSSMMMSMMSXMAMXASASMMXXAMXMXMAXMMMMAAAXAMASMSAMAAAXAXMMMMAAXMSASAXSAAAMAXAMXMAMXMAXAXMSAX
        AMAMSMMMMMMAXSAMMSSSMMMMMMSAAXAAAXXSMMSMSMAMMXXMMMAMAXMASAAMAMAASMAMXMAAXMSSXMXSXSMMXSSMMSAMXSXMAMSSMMXAXAAMMSMXMAMAMMMMSXSMSAMSMSAMMSAMXMMS
        MXSSMAAXSSSSMMSSMXMAXAAAAAMMMMXSAMASAXXXXXMAMMMAXSAMSASMSSSMMSMMMMAMASMMMAXMAMASAAAAXXAMAXMMMMXSXMAXAMXSXXXSAXXXMSMSMSXAMAMAXAXMXSASASXXAMXS
        MAMAMXMXAMAMAMXXMASAMSSMMSMXXMAMAXASMMMSMMSAAXSAXXXMXASAXAMXMAXSXSMSMSAMMMASXMASMSMMMSAMSSMSAAAAAMASXMAXSASMMXASMXAAASMSMAMASMMAASXMASXMAMXM
        MAMAMXSAMMMMSMXAXAMAMMXMAAMSASMSMMMXMAAAAASMSAMXSXMXMAMAMMMSAMXMASAAXXMXASMMXMASMMAAAMAMXAASMSMSMMASAMASMMSAMSAMAMSMMMAAMMMXXMAMXXAMMMMASMSM
        SMSXSASAXXXMAMSSMSSXMXAMXSMSAXMAMAMMMSSMSMMMXXMASAMSMXMXMAAMAXMSAMMMMSMSMSAMXMASASMMSSSMSMMMMAMXAMXSXXMAXXXAMSAMXMXSAMXMSXMSMSMSSMMMSAAXXAAS
        AAAAMASXMXMMAMXXAAAXSXMSXMAMXMSASAXMAMXXXXMASASASAMXMAXAMXMSSMAMASXXXAAAASAMXMAMAMAMXMXMASAAMMXSAMXMAMXMXMMSMSMMMSAMXXMAMXXAAAAAXAAASMSXMSMS
        SMMSMMMMMMSXMASASMMMSAAMMSAXXXSASASMASMMSAMXSAMASMMXXSSMXXMAXAMSAMMSSMSMXSAMXMXSSXXMXMASMMXMSMASAMXSMSAMMSXXAXAAAMASASAAXMSXMMSMSMMXSAMXAAAM
        XAXMAXAAAAMAXAMXXAXASMMMAXMMSAMXMXAXXSAASAMAMXMAMAMAMMAMSSMMSSXMMXSAAXXMAXAMXMMMMAMSXSASXSSXAMASAMXAXSASAMMMMMSMMSAMASXMAMMSMAXXAXSMMAMMMMSM
        SMMSXXSSSXSMMSSMSXMAXASMXMAAMASASMXMXMMMSAMXXXMAXAMAXXAMXXAAAMXMAMMSSMMXSMSSSSXAMMMAAMASAAAMAMASAMXMASAMXMAAAMAMAXMMAMAXXAAAMXMMMXSASXXAAAAM
        MXXMXAMAMMAXAAAAXMMMSMMASXMMSAMASAASXMSASMASXXSSSMSSXSAMMMMMXSAXMAXXMAXAAMXAAXSAMXMMXMXMMMSMMMXMAXAXMMXMASMSMSASXXMMASMSSMSMXSXXSAXMMMMXMSSM
        MMSSMMMAMSAMXSMMMMAAAMMMMASAMXSMMXMSAAXAXMASMAMXAAAAXSAMXAAAXSAXMXMASAMSSMMMMMMSAXXSXXSASAMAXXXSMSSSXXXXASXMMXAXXAMSXSXAMAXAASMMMXSXMASMMAAX
        SAXMAXMMMMXMMXXAAMMMXMAXXAMASAAMXXSMMMMAMMMSMAMASMMSMMAMSSMSAMXMSSSMMAXAAASAMXMAXSMSAASAMAMSMSMSAAAMMMSMXXAMASMXSAMXMMMMMAMMMMAXAXSASASMMSSM
        MXXMXMMMSMSMSASXSMSXSSSSMASAMMXSAMMAMAMMMSAMXMMAXXXXMXSMMAXAAXXAXAAMSXMMMMXAMAAMXSAMMMMAMSMMMAAXMMMXMASMSSSMAXSAMXSAAXMXMASXSSMMXXSAMMSAMMAM
        SMSMMASAAMXAMAMAMASAAAAMXAMAASAXMAXAMAMSAMAXASMASXXMSAMAXMMSMMMMMSMMMMMSSSMSSSSXSMMMAAXXAAXXAMSMXASAMXSAAAAMASMMMAMXXMMSAMXAMAMXXMMMMASAMSAM
        AMAASAMXSXMSMAMSMAMMMMMMMMSXMMXSXSSXSASMMMSMAXXAMMASMASXMMXXSXAAMAXAAMMAMAAAAXMXXAASMSMXSXASXMMASASASAMMMSMMMXAXMASMSMASAMMSMMMXXSSMMXMMMMSM
        MMSXMASAXXAMSXSXMSSSXMXSAMXMSAMXAMAAMXXAXAMMMMMAAMSXSXMMAMXMASMMSASXMSMAMMMMSMSAXSMSAMXAXXXXAXXXMASAMMSMAMAMMSMMMXAAAXAMAXSAAASMMMAMSSMSAAAX
        XXMAXAMAMMSMMMXAXAAMXMAXMXAAMXSMMMSMMXSSMMSAAAXSAMAAXXXSAMMAMXXAMMMXAXXSXSAMXAMAXMAMAMMMMMSSMMXXMXMASAXMASASMAAAXMMSMMASXXSXSMXAAXAMSMASMXMS
        MMSSMMMSMMXAMASMMMSMAMAMASXSMAXASAXXSAXMAMSXMXXAMXMMMSMSASASXXAXXSAMXMXMXMASMMMXAMAMAXAAAMAAAXMMSXMAMAXSASASXSSMMAXXXXAMMMMXXMSSMSSSXMXMMSMM
        MAAXAXAMMXMAMAXSAXMXAXSAMMXAMXSXMASAMMSSXMXAMXMAMSMXAAAMASAMXMASXMASMXAMASXMAXSMMSASXSMMMMSSMMAAAAMXSXMAASAMXMAMMSMMMMMMAAMSMMMAAAXMASXSAAAX
        MMSSSMMSASAAMXSXSAMXMAMAXSSSMAAMMAMXMXAAMSSMMASAMXAXSMSMAMAMSAAMAXSAXMASAMASMMSAASASMMMSSMXAAXMASXMMMMSMMMXMXXXMXXAAAAASMSMAAASMMMSXAAAMXSMM
        XXAXAAAMASMMMXMAMXMAXAXAMXAAMXSSMXSAMMMSMAAASMSMSMMMAAAMAMXMMMSSSMMAMMAMAMAMMAMMMSSMAAAAAASXMMSXMASXMAAAAXMMMMSMMMSSSMXAAAXXSMSXSXXMXMXMAMAM
        SMMMMSMMMMXAXXMAMASXSSMSAMSMMMXXMASXXAAAMMSMMASXAAASMSMSSSXAXAXAMXSASMSXSMSSMSSSXSASXMMSSMMMAXMASAAAMSSXMXXSAMAAAXMAXXSMSAMXAMXMXMASMXMMASAM
        MAASXMXSMMSSSSMXMXMXAXAXSMMXXAXMMASMSSSXSXAMAMXMXXXXAMAMASMSMXSAMXMASXMAAMAAMMAMXSMMMSAXMAXXMXMASMSXMAXAMSMSASMSMSMMXMXAXASAMXXXMAMAAASMASAM
        MSMSASAXAMAAAMMXSMMMSMXMMSXMAMMXSAMXAAAASMSMSXAMMMSSSMMXAXSXAXMXMAMXMAMSMMSSMMAMMMXMAMMSMSSSXAMXXAAMMASXMAAXAMAXMSAASAMXMAXXXMXMXSMMSMSXMMXM
        MAXXMMMSSMMMMMMAAAXSXSXMAAMMSMAXMASMMXMXMAMAXMXSAAAAXAXMSSSMMMMSMSSXMXMAMAMAXSMMAAAMAXMAMXAMSSMSMXMXSASMSXSMAMAMMSXMMXXMMMMSMMAXAAAAMMXAMSMS
        SSSMAAXMASXXMAMSSMMMAMMMAMSAAMSSSMMAXSXMMAMMMMAMMMMMMMXXMAMXXAXAAXXMMAMASAAMMAMXXXXSASXMMMMMAMMXAAXMMMSAMAAXXMXSXMMMXMXMAMAAASAMSSMMSMSMMAAS
        SAAMSMSMMMMMMAXMAMAMAMAAMSMMMSAMXASXMASAMASAAXAMXXXXSSMSMAMMSSSMSMAMXMXASASXSMMXSAMSAMXXAAAMMSMSAMSXSAMAMSMSSMASAAAXASMMAMSMXMSMMAAAXAAMMMMM
        MXAMXXMAAAAAXMMMAMXSMSSSMAMXXMASXXMAMAASAMXXASXSSMXSAAASMXSMAAMXXXMMASMMSAMAAXAAMAMXAMASMSSSXAAXXAXAMASXXXASAXAMXMMMXMAXSMMXSAXSSSMMSSXSSSSS
        MSXMAMXMSMSXSSSSMMXXXAXMMAMXMSXMMSAMXSAMXMASXSXMXAXAMMSMMMSMXXSAMAMSASAAMAMSMMMMSAMXSMAXXAXXMMMMASMXMMMMMMMMMMMSASXMSMSMXASAMXMAXAMMXMAAXXAA
        AAASMMMAMAAAXAMMASMSMMSSSXMMASAMXASXMXASAMXSXMASMSMMXXAAAAXXMMMASAMMASMMSAMAXASXSASAXMASMXMMXSXAMAAXMASXAMAAXAXSAXAXAAMASAMXMAMMSMMXAMMMMMMM
        MMXMAAXAXMMSMAMSAMAXAAAMXMASAMAXMAMSMSASXSAMMXXMAMAXSSSSMSSXAXMAMAXMXMAASMSMMXSAXAMASXXXMASXASAMXMSXSASXSSSSXSXMMSSSMMMAMXMASASXSXAMMMMAAMAM
        SSMSSMMXSMAXXXMMASMSMMMSAAMMASXMMSMMMAAMAMXSMXSSXSSMMXAXAXAMSSMMSMMSASXMSAAXSSMMMXSXSXSASASMXSASAXXMMASAMAMXAMXAMAAXAXSMMASXSXSXMAMSMASMMSAS
        MAAXXXMXXMAXMSSMMMAAXSASASMMMMMXXXAAMMMMXMAAMAAMAMXMXMMMSMMSAAXAAAXSAMXSMMMSXAAXMAMXMASAXSXMAMAMXMMXMAMXMAMMMMAMMMSMXMAASXMASAMMAMSAXXSAMSAM
        SMMMMASMMXSSMAMMAMMMXMASAXMAMAMXXMSMSXMXAMMAMMMMSMSXXXSAMXXMMSMSSSMMAMXAMXXSMMMMMASAMXMMMMSMXMSXSSMSSSSSXSAMXASMSSMMMSXXMAMAMXMAAXMAMXMAMMAM
        AAAASAAAMAMAMMXSAXAAAMXMXAMMXSSMMMXAMXXSXMXXXAAXMASAMXMASMMMXMAXXMASAMXMSSMMASXXSASXSAMXAAXMAAMMMAAXAAAAXXXXXXXSXAAAASXSMSAMXSSMXSMAMXSAMMAM
        XMMMMAMXMXSAMMASMSMXMMASMSASAMAASASASAMXAMSMSSSSMAMMMXMAAAAXAMMMASASAMXXAAAAAMMXMASXXMSSMXSMMSMASMMMMMMMMSMMSSXAMSMMXSAMAAAXAMASAMMAMXMAMSMS
        SASXSSMMXXMAMMAMAXMASMMSAXAMXXSMMAMXMMAMXMAAXAMXMXSXMASXSXMMMSMSXMASXMXMSSMMSSXXMMMMSXMXXASAMAMXMMAXXXAAAAASAMMSMXXXMMAMMMSAAXAMMXSMSSSSMSAA
        XAMAAXMXASXMMMMSMMSASAAMXMSMSXMXMSMSMSMXMMSMMASXSAMXSMMAMXAAAAAMXMAMASXXAMXXMMMXXAAXMAXXMASASASXSSXSXSXSMSMMAMAAXXXMASAMAAXMXMXSXXMAMMAMAMXM
        MSMSMMSAMXAXMXXAXXMMSMMSAMXAASMAMAAMASXAMAMASAMMMAXXAAMSMMXSXMXMAMASXMSMSSMXXAXMSMXSSMMMMASAMXMAASAMASAAAMMSSMSSSSXXAXAMMAMMXMSMMMMAMMMMSMXM
        AXAXMAXMXSMMSSSSSSMXSXXMASMXMXMAXMXMAMXMMASXMAXASXMSMMMXAMAMAMMSASAMAAAMMAMSSMMXASXMAMXXSASASXMSMMSMAMMMMMAAAXMAXMMMMSSMMSXXAXXXAASAMSAAXMAM
        SMAMMMSXAAASXAAMAMXAMAMSMMMMSASMXSAMXSSMAASXSXSXSSXXAAASXMASAMAAAMASMXMMMAMXASXSASMSAMMMMASXMAMMAXAMXXXXAMMMSSMSMMAMAAMSAAXSXMMMSMSAAXMAMSAX
        MMXMAXXMMSMMMAMMXMMMXAAAMAMSMAAAASXSAAXAMXXAXAAMMMMSAMXSAMXMAMXSMSMMXSXSMMMSMMXMMMAMAMSAMAMASAMXXMMXSSMMSSMAAMXMASMSMMSMMSMSAAXAMXMMMXXXMSAS
        SAXSMSMSAMAAXSXMXSXMSMXXSASXMSMMXMXMASMMMSMMMSMXXAAXAMXXMASXXMXMMXMAASXSASASASXSSSMSSMXMMMSMSXMXAMXAAAAMAXMMSSSMAMAAXMAXMMASMMMSSSXAMMMAMMSA
        MAMAAAAMMSSMSASAMMAMAMSMXXAMXAMXSMXXAXAAAXAXAMXSXMMSAMMXMAXXMSMXXAMMMSASMMASAAAAAAAAXAAXMXSAMASXMSMMSSMMMSXMAAXMAXXMMSASMMAMXXAXMASMXAAAXMXM
        MSSMMMSMAAAMSAMXAMAMASAASMSSSMSAAAAMXSSMMSXMXSASAMAMMAMXMMSMAMAXMSSMXMAMXMXMMMMMMMMMSXAXSAMAMAMAAAXAAMXAAMASASXSMSMSAXMSAMXMXMSSMMXXSMMXXSAM
        XMAMXMXMMXMMMAMASXXXXXMXMAAXXAMXMXXSMMXXXMASAMASMMASXSSMXMXAAMMMXAAAAMAMXMASMXXXXXXXMXMSMMSAMXSMMMSMXSXMMSAMMMAAAXAASXASMMASXMMAMXAAASMSXSAS
        MSAMSXSXSAMSSSMAMMMSSMSAMMMSSSMAXMXMASAXMSMMMMMMASAMXAAXMSMSXSMSMSSMSXSAMXXMMMSMAMSXSAXAAMMAXAXXXXAMMSAAAMMMAMSMSMSMMXAMXMAAAXSAMXSMAAXMASAM
        AMAMXAMAMMSAAAMMSAAAAASMXSAMAAXAASMMMAMMMAXAMASXMMXMASMMAAAXXSAAAMAXAAXMASAAAAAAAMAAXMSSSMMASMXMASXMASAMMSXSXXMAXXXAMXXSAMXSAMMAMAXSSMAMXMMM
        SMSSMAMAMMMMSMMXSMSSMMMMAMAMSMMSSMASAXMMSAMMSASMXMAMMAMMSMSMAMXMXSMMMSMXSAMXMMSSXSMSMXMXAAMAXAASAMXMXSAMXAMMMMMMMMSAMXXXXMXMASMSMMMMMXXSAMXM
        MXMAMMXAMXAXAAMMMAXMXSAMXSXMASXXXXAMSSXAAMSMMMMAXMAXMAXMXMAMMMASMAXAMAMXAMXAMMMMXMAAAAMSXMMSXSMMSSXXXMASMMMAAAAAAXSASXSXSAMXMMAMXMAMAXMAMSAS
        SMSAMSSXXSASMSSMMAMMSSXSAMXSASMXMMMSMXMSSMAXASXSMMAXSSMMASASXMASASMXSAMXXSXXMAASAMSMSXXAAMMMAAXAMXASXSMXAASXSXSMSMSAMAAAAMXSSMAMXXMMMAMXMSAS
        SAMXSAMSAXASAAMXXAXXAXMMXSXMASAAAAMAMAAAAMXXXSAAXXAMXAMSASXSAMASXXAXSAMSMSAMSSSMMXAAXMASXSAMXMMXMMMMAAAXMMMAMAXXMMMMMMMMMMAMAMXSMXSASAXAMXXS
        MMMXMAMMSMAMMMSMSMSMMSAMASMMMMXSMMSAMSXXAMXMSMMMMMSSSMMMASASXMASXMXMMAMMAMAMMMXAXXMSMMMAAXXXMXXAXAMMSMMSMAMAMAMAXXAXAAXXSMXSMMMSAASMSASMSMXS
        MSXMMSMAAMXMAXAAASAAXXXMASXXSMAXAASAXXMAXAMXAAXMAXMAXXAMXMXMXMASMAMMMAMMSMMMXASMMXMAAXSMSMAMASXMSMSAMXAAXAMMMMSAMXMSXMMXASAAXAAMMMSXMAMXAMAM
        XAASAMMSMSSMXSSSMSSSXMXMASXAXMAXMMMSAMXXXAXSMSMMMMMAMSXSAMXSXMASASAAASXMXAXSMMMXMASAMMXAXMMAXSAAMXSAMMSSSMSXAAMMMSAXXSSMMXMXSMSSSXXMMSMSMMAS
        MMSMASMAXAAAAMMAAXXMASAMXSMMMMSXMMXMMSAMSSMAXMMAMSMMMSXXAMASASXSXMSSMMASMSMXAXAXMASASAMAMMXSASMMMASXMAMXMASMMMSAAMXMXXAAXMSAMXXMMMXXXAAAXSAX
        MMMMMMAMMXSMMSXMMSAMXSASAXASXAMAMAMMAMAMAAMMMSMAMAAAAMMXSSMMAMAXXXXMXSAMAMXSMMSSMAXAAMMXXXAMAXASMXSXMXSMMAMAAMMMMSAMXSSMMAMASMSASAXXXMSMMMSS
        XSXAAXXXMAXMMXASAMAMASAMMSAMMSSXMASMAMMMMSXSAMMMMXMMSXSAAAAMSMMMSSXMXMMMAMAAXAAMMAMSMMSXMMXSASXMXSMAMXAMMAMMXMASMSASAMAMMSSXMASAMSSXAXAXXAAM
        XASXMSXAMAXAXSMMASXMAMXMMMAXXAAASAXXAXMAMMAMASASMSSMMAMMSMMMMAAAXMSMSMASASMSMMSSMMMXAAMASAXSAMMSMMSAMXMMSMXSAMXMASAMXSAMXXXMMMMMMAMXXMASMMMS
        AMAMXMMMMMSMMSXSAMXMASAMXASMMMSMMASMMSMASMAMAMASAAXAMXMXXAMMSXMMMAAXAMASMSMAASXXXAAMXMSAMSMMXMAAAMMMMSAAXAASXMASMMSMASASMMASAXAAMXSAMMAMAXSX
        SMASAXAXAAAAXXMMAXXMAXASAMAAXAXXMXMAAXMXMMXMAMXMMMMMMMSMMMXAAAMSMXMSMMASXXMXSMMXSMSXMMMAMXXXAMSSSMAAAMMMXMMSASXSXAXMXMAAAMASXSSXXAMXXMASMMSM
        AMAMAMSMMSSSMSXSXMMMSXMMASXSMSSMMAXMMSAMXMXSSSSMMSAASAAXMAMMSSXAASXSAMXSAMXSAMMXMAXMAASMSMMMAMMAMXSMMSSMSAMXXMAXMASXASXSSMMSXMASMSMSASAMXAMX
        MMSSMAMAMAMAXMASXMAAXASXMMMMAMAASMXSAAASASMMMAAAASXSMXMSMXMXAMMMMAASMMXSMAXSAMSXSASMSMSAAAMSSMMAMAMAXAAMSAMXMXXXAMMAMXAMAAASMMAXMASAAMMSMSSX
        XXAAAAMAMMXSMMAMXMAXSAMAMXSMSMMMMAAMMSMSASXAMSMMMSXXMMSAMSSMMXXXAMXMXXAMXSXSAMXXMAMMAAMMMSXAAASMMXSAMMXAXAMXMXXSMMMAMMMMSMMXAMASAMXMXMXAXMAM
        SMXXMMXSMSAXMSAASMMMXXXXSMMAXAMXMMMMAAMMMMMXMAAAAMASAMSASAAXSASMXSAXAMXMAMXSAMXSMXMSMMMXXXMMSMMSMASXSASMSSMAMSMMASXXSXXAXAMSSMMAMXXXMSMMXMAS
        SAAMMMXAAMXSASMXSAMXMASMXAMAMSAMXAXMSXXAXMSMSSSMXSASAMSXMMSMSASAASMMSMSAASASAMXXAXXMMMXAMSMXAMXSMAMXAXXAAXMASAAAAMSAMXMASXMAMAMSAMXSAMASXMAS
        XAXSAASMMMAMAMMASAMXAXXSSSMASXXMSXSMMMSMXSAAAAXAMMMMXMXMXAXAMAMMXMAXAAMSAMMSAMXMXMXAXMMSMMMAAMAXMASAMMMMMSSXXXSMAMXMMAXMMAMXSAMXAMASMSAMAMAM
        MSMMXXXAAXMAMSMASXMMSMMAXASMXXAXSAMXAXAAMSMMMXMXSASMSMSMMSSSMAMXSSSMMXMMMAXSAMXAAAXMMSAMXAXMXMSSMASAAXAAAMAXMAMMMSASMSMSAAMMSMMSAMASXMASXMAS
        AMAXSXSXMMAMXSMMMMSXAAMMSMMMMSMMXMASMSMSMMMMXXSMSAMAAASMMAAXMASMAAMXSAAMASXSXMAXXSMXAMSSMMMSAXAAMAMMXMMSXSASMAXAAMAMAAAASXSXXMASAMAMASAMASXS
        SSMMAAASXMASXMASMAXMMXMXMXAAXAAAXMAMMAMXXXAMMMSAMXMXMMMASMMMSASXMXMASXSMAMMSASXSAAMMMSASAAASMMSXMSSMSMMXAMAMMSMMMSAMXMMMXXMXXMAXXMMSAMASAMMX
        XAAXMMMAXSAMMSAMASXMSXSAMXMXSMSAMXSMSASMSMSSMASXSMSASASXMAAAMXSAMXMXSAMMMMAMMAAAMMAAXMASMMMMMAXXMAAAAAASAMXMXMAMAMMMMMMXSMSMSMXSAMXMASXMASAX
        SSMMXAMXAMASXSASAXXMAAMAMMSMAXXXSMMASASAXXMAMMMAMAMASMAASMMMSASAMMXMMAMAXMSSSMMMXXMSMMXMXSSMXAXMMSSMSMMMAMXMASMMASAMAMXAXAAAAAASXMASAMXSMMMX
        XAXXSXSMXMASMSAMXXAMMMMAXAAMMMXAAAMAMAMMSASAMAMAMXMASXSXXMAMMASMMSAMMXMXMMMMMASXMXXMASASXMAAMMSAXAMAMAMSMMMMAXMSMSMSASMXSSMSMSMSASXSAMXXASXM
        SAMXXAXXXMAMXMXMMMMMASMMMSXXXMXSMXMXMXMAMMSMSXSASXMASAMAMXXXSAMAAXASMSMSAXMMSAMAMSXSAMAMXMAMMXAMMAXAMAXAMAXMXSMAAXXMAXXXMXMXMAMSAXAMAAAMXASA
        MAAAMAMMMMSMSAMXSAAMAMAAXAMXSAAMXXMASXMASMXMXXMASXXAMAMASMSAMASMMSAMXAASAMXXMMSSMAXMAMSMSXSSXXSMMMMASXSMSSSMASMSSSMSMSMMMAAAXXAMXMMSSMSXSASM
        SMSXSAAAAAAAXXMAMXSMMMSMMAXAAMMMMMSASASXMMAMMSMSMXMASXSXSAMXSMMMMAAAMMMMMMXSAAAXMMSSMMMAXAXMAMMAXAAMAMXXAMMMASAMXAXAAAAAXXSSXSMMMAXAAXAAMAMM
        MAMMMXXMMSSXSAMXSMMMSAMMSSMMMXMAAMMMSMMMMSMSAAMAMAMXMAMAMXMXXXAXXMXMASXAXMAXMMSMXXXAXSMXMXMSAMSSMMSXAMSMSSMSMMXMMMMMSMSMSAXAASAMMSMSSMMMMMMA
        MAMAMMSSMMAASXXAAXAAMMSMAXXXXMMMMSAMSMMSAAMMXXSMSMSSMMMAMAMXAMMMMXMMMMSXSMSMSXMASASMMMMMMXXSAXXXAXMMMMSMAAMSASMSMSAMXAAAMAMMMMAMXXAMXMASAMXX
        SASXSAXAAMMMMXMSMMMXXAAMMSMMMSXXXSMSMAAMMXSASMSXSXAAAXSXSASXMASASASAAXAMSAXAMXXXXAXXAXAAAAASMMASMMSXSASMMXMSAMAAXMSXMMMMMSXMASAMXMMMASXSASXS
        SMSAMXSSMMSMAXXAXAXSSSMSXAXAAMMMAXMXMMMSMMMASASAMMSMMMSASASMMSSMMAMSXMMXSAMXMMMMMMMSSSSMXXAXAMMMMAMAMASXAAMMXMMMSMMXMXSAMXXSMSXMASASMSASXMAS
        SXMXSAXAXSAMXXMASMMXAAASMMSMMXAXXMMAMMMMMXMAMMMMMAAAXXMAMMMXMAXMMSMMMMSAMXMAAAAAAAXXMAXMSXMXMMMAMAMXMAMMSXMAMXAXAAMXAASMSMXXXMAXMAXSASAMSMAM
        SAMSAXASMMSSMMSAXXAMMMMMAASXSMXSAAMMXAAAMXMASAAAMSSMMMMAMXSAMASMAMAXXMAMMASXSSSSSXXAMXMXAASASASXSMSMXSSXXXXSASMSMSMMMXSXAMAMMSXMMSMMMMAMAMAS
        SAMXMSMMSXAXXAMXSAMMAAMMMMSASAASXMMXSMSSSXSAMXSXXAXMAXMAXXSAXAAXAMXSASXMSMSXMAMXAASXMSSMMMSAMASMSAAMSMMMSMMXAXAXXMAXSXMMMSMAMAMXAAMAMXSMMSAS
        SSMAXXAAMMMSMMSAMMSSSSSSXXMAMMMMSXSASAAAAAAAMXXMXMASMSSSSMSAMXMSXSMAAAAASXMMMMMMMMMAAXMAXAMMMAMAMMMMAAAAAAAMMMMMSSSMMAMAMAXXAXSMSSSMSAXAXMAS
        SASXMMMMMAAMAAXAAXMAAXMASAMMMXAAXXMAMMMMMMMXMSAMMSAMXAAXXAXXXAXMAMAMSMMMMAMSMAAMASMMSMSMMMAMMXMMMMXSSSMMXXMXSAMAMAMMSAMXSASXMXXAMAAAMAMMMMAM
        SAMXSAXSSMMSMMSAMXMMMMSMAMMAXSMMSAMAMASAXAXMASAMASAMMMMMMSMMSAMMAMSXXASXSAMAMSXSAMMAMXXXAXSAMAXAASMMAAAMSSSMSXSAMAMXXMSMMASMXMASXSMMMXMSMMMS
        MAMAMMMXASAAXASXSMXMMAMXASMSMSAAMXMASXSMXMXAXSAMXSAASASAXMAMXMASASXMXXMASASXXXMMXMMAMAASMMXAXMMSXSAMSMMMAAXAXMXXSMSAXSAMMAMAXMAMMMAXSAMAAAAX
        SMMSSMXSAMSSMXSASXAXMASXMAAXAMMMSASXSAMAASXSXSMMXMMMSASASMMXAMMSMSAMSAMXMAMMAMXASXSASMMAMASXMMAMXSAMAXMMMMMMMSMAAAMMMSASMAMMXMASASXMMMSXMMMS
        SXAXAAAMAMAXMMMAMSAMSMSXMMMMXMMXMASXMXMMMSAMAMXMAAAXMXMMXAMSXMASMSAMXXMAMXXAMAMXMASAXXSAMMMXXMAXASXMMMMAMAAXAAMXMSMMASAMXMASMSXSXSAMXAAMXSMM
        XMAMMMMSSMXSMAMAMASXAXSXSASMSSMASMMMXMMXMMMMAMASXSMSMMXMSAMXMMMSXMMMSSSMSSMAMSSSMAMAMXSXSAMXXMMSXMMSXASAXSSMSSMSAAXMAMMMAAMAAMMMXSMMMMMXAAAM
        SMSMXXMAMXMAXASASMASMXXASASMAASAMAAXMAXASAMSXSASAMASAAAMSASXMAAMMXMMAXAXAXMAMXAAMMMMSASMSAMMASAMXAXXMMMXMXAMXAAMSMSSXSASXSXSXMAMXMXAAXASXSMM
        AAAMXXMASXSAMXSAMXMXXAMMMMMMSXMXSMMSAMSMMAMMAMXSMMAMMSXXSXMASMXSAASMMMSMMSMAXMSMMXAXMAXASAASAMASXXMMSSMMXMAMMMMMMXXAAMAMAAXAASXSASXSMSASXAXM
        MSMMAXMAXMMSAMXMXAXAMMXSAAXXMMXAXXAMAMSXSSMMXSMMXMMMXXMASASAMAAMXMXAMAAAXAXASXXMXSXSMSMAMXMMASAMXMXMAAAMASMXSASAMMMMMMAMXMMMMMAMAMAAAMAMMMMM
        MAMSMMMMSAAMSSMMMSXMXSASAMXAAMMAMMXSASXAXMASAXMAMMMAXXMAMMMMMMMMMSMSMSMSMMMSXXAMMMMXAAMXMAMXMMASXAAMMSMMAAXAXASASAAXASMXXXMXSMMMSMMMSMMMAAAX
        XAMAAMAASMMXAXAMXMAAAMXMASMXAMMSMAXSMSXMASXMASMSXSAMSMMASXMSAXASASAMXMXAAMSXXSSMAAMMMMXAMMSAXSXMASXSAXAMXSMMXXSAMXSSMMSMMAMAMASAXXSMMAXSXMMM
        SSSSSMSASMXMMSSMASMMMSASAMMXSMAAMSMXXSAMAXAXXXAXMAXSAAMAXAAMAMMMAMAMASXSMMAMXMASMSSMSSSSSMSXXXMXMAAMMMAAMMAMSMMAMAMAAAAMXAMAXMMAXXMAMXMAASMS
        AAXAXAMMMMSAMAAMMMXMAMMMAXMAMMSMSXMSMSMSXSMMSMMMMSMSMSMSSMMMSMSXXMAMSMAXSMMMASMMSMAAAAXMAMXXSMMSSMMAXSSMMMAMAASXMMSSMMSMSASASMMSMSMAMAMXAXAA
        MSMMMXMAAMSAMSSMSAAMSSXXMAMXSAMXMAAXAMASAMXASASAAAASAXAXXAMAAAXMASXSMMSMMXXXXSXXASMMMXMSAMXXAAAAAAXMAXMASMSSXXMSMXXAXXAASXMAXMAMAMMAMXMSMMSM
        MXAXAMSMSMSXMXMAXSMXAAXMXMXXMAMMSMMSSMAMAMMASAMMSMSMAMXMSMMSMSAMXAXAMAAAMXSAASXSMSXMXSMXMSSXSMMSXMMMXXMAMSAMXMMXSASMMMMXMAMMSMAMAMXSAMXMXAMS
        MSXMMMXAMAMSMMMMMAMXMSXSASMMMMMAXAAAMMSMMMSAMXXAXMXMAMMMAXAXXMASMSSMMSMSMAAMAMASXMASAXXAMAXAXAMXMMMMMSMXSMSMSSMASMMAAXSASAMAAXASXSAXMSXXMASA
        XXSAXMMMMAMAXAXXXAXXXMASASAAAAMSMMMSXAXSAMXXMXMMMAMSASASXSMMXSAMXAAXAMXXMMMXAMAMASAMASXSMASXSASXSAAAAXMMXAMMMAMXXXSMMMXASMSXMSMSAMASXMAAMSMM
        AASXMXAXSSSMSMSAMXSXAMXMXMMSXSXXMSXMMMSAMXSXAXMAMAMSXSMXAAASAMMSMSMMMSXMASASXXSSXMASMMMMXXSXMAMASMSMSXMAMSMASASMSMAASMMXMMSXXAAMAMAMAXMAXAAX
        MMMAXSSMXMAXSASMAAMMSMMMXMAMXMASXSXMAMAAASXSMMMASAXXAMAMSMMMASAXXXXXMAMSAMXMXSAMMSAMASMMSMMMMAMXMAMXMMMSAASXSASAAAMMSAXXAAXSXMSMXMASXSMSSSSM
        XAMSMMAAXSMMMAXXSXAAAAAMXMASAMAMAMAMSXXSMSAXSASASMMMSMAAXAXSXMMSMMAXXAAMASXSXAAMAMASAMAXXAAASXSXMXMMMAMXSXSMMAMMMXXXSAMSMMXXXSAMXSXMXXAAAXXX
        SXMAAMAMMSXXMAMXMMMMSMMXMMASAMASXSAMASMAMMMMAXMXMAXAAMMMSSMXAAAAAAXMMMSSMMMAXSSMXSXMASMMMSMXMASXMASAMAMAMXXAMXMASXMAXAAXAMXSXSASASASXMSMSMSA
        XMSMSMASAXMXMAXAAASXMMSAXMASXMMSXMAXAMXAMAASMSSMSSMSXXXAAXASMMSSSMSAXAAAASAMAMAMASASAAAXAAMAMAMAXAMMXXSMXASMMMSASAMAXSXSMMMMASXMASAMAAAAAAAM
        SAAAAXMMMSAASMSMSMSXMAMASMMSAAMXASAMSSMSSSXSXMAXAAXAMSMMSMXAMXMAAAXXMMXXMMSXMSAMASAMMSAMXSMAMASMMSSMSXAXMAMAAAMSSXMMMMAAMXAMAMASXMAMXSMSMSMX
        ASMSMSXMXMXAXAAAXAMAMAMSXXAXMASXMMXMAAMXAAXMASXMSSMMSMAAXMASMSMMMMMMSXMSSMXSASAMMMAXXMXMSAMMSMSAMXAASMSMSSSSMMXAMXMMAMXMMSMSXSAMXSXMAXAMMMMM
        MXMMASMSXMXSMMMMMAMXMSSXAMMXXMAXXASMMSMMAMASXMMAMXMXAMMMMMMMXMASXAXMXAMAAMAXMSAMXXMASMAMXMAMAXXXMMMMXAMXAAXXAXSSSSSMMSAXASASMMASXMAAAMAMAAAX
        XAMMAMAAAMAXASXSSXMXXXMAXMXAXXMXSASXAXXXAMXSMMMSMMMSMSXMAXAMSXMMSMSASMMSSMXSXMAMXMMAMMASAXMSXXMAAXXMMMMSMMSSSMAAAXXAASMMSMAMXSSMXSMMMAASXSSS
        SXSMAMSSXMAMXMAXXMMSMMSSMMXMXASAMXMMXSXXMMXMASXMAXAXXAXSSSMXAXSXMMSAMSAMXMAMMSMMMXMAXSXSMSXSAMSAMMMSAAAMXXAAAMMMMMMMMMXMMMMMXSXAAXAAXSXSAXAX
        MXMXMMAMAXSXMMMMMAXAAMAAAXASXAMXSMSSSMMSSMASXMAAMMSXMMMAXAMMSSMAXAMAMMMSMMMXAAAAAASMXXASAXXMAMXAXASASMMMMMMSMSXXAAXMXMAMSAXSXMMMMSSMXXMMXMAM
        SSMMSMASMMMAAAAASMSSSMSSMMASMMMXXAXSAAAAASASXSSXMAXAMXSMMXMAXAMMMMSMMXMAXAAXSSSMSASXSMAMMMXMSMSSMSSMMMSAMXXXXMASMMSAAXMMSXMSAXSMXMAXMAMAMMMM
        AAAAXXAMAAXMSSSMSAMAAAXAMXAMASAMMSMMXMMSMMMSAXMAMASAMMAMXSMMSAMXAXAMMSSMSXXMXAAAXAMAXMXMXXXMXAAAXAXXAASASXSMSXXMSASMMMSMMSASAMXMSSSMSAMASASA
        SSMMSMMSMMSXMMAMXAMSMMSXXMXSAMASAXXMASXXASAMXMMAMXSMMSAMAXAAMAMMXXASAAAMMMMAMXMSMMMSMMMXXMAMAMMSMSAMAMMAMAXAXMXSMMSAXAAAASMMMMAXXAMASXXXSASX
        XAASAMMAMSMXSSMMSAMXXMAMXMAMMSXMXSASXSASAMXSMASXSMSMMSAMASMMSXMASXMMMSSMAAXSXMXAXAAAAXASXMMASXMXXAAXAXXAMXMSMMMXAASXMMSMMSXMAMXSMAMAMMMMMMMM
        SMMMASMMMAAAMAMAMASAMMAMXMASMSMSXSXMAMMMMMMAXXAASASAAMAMXMAAXAMXSASAMAXMMSXMASXMASMSXMMSAAMAMAMAMSMMMSSMMXMMAMAMSMSASAAAMXASXSSXXXMAMMASAMAM
        AXAMAMAASMSMSAMXSAMAMXSXMXXMXMASAMAMSMAAAMSMSAMXMASMMSMMAMSMSSMAMAMAMXXSAMXSAMAXXMMMMSXSMMMASAMXAAXAAMMSSXMSAMSMXASAMSSMMSMMAXAMAXMMMSMSAXMS
        XSXMMSXMMAAXSXSAMXSAMMXAMSMSMMAMAMAMAMSSXMAMMMMXMAMXMAMSXXMAAMMSSMXAMXMMASASXSXMASAAXAAMAMMXMAMMMASMXSAAMXMMASXAXAMAMAMAASAMXMMAXMASASXSXMXM
        XMASXMMMMSMMXXMASXMASAMAMAAAXMAMSMSXSXMAMSMXAAXXMXSMSAMAMAMMMSAMAXMAXXMSMMASMSMSMSMMMMMMMXSASMMSXMXMMMMMSMXMMSMMMXMXMASMMSMMAMXSXMXAASAMMSAA
        XSSMMMAAMAMMMMMAAASXMMMAMMMMXMAMMAMAMMMAMSXSXSSMMMMASMSAMXSMAMAMAMMMMMMAXMAMXSASXSAMXAAMXMXAAMAMAXAMAAAMAAXMAXAMXSXXMXSMASMXXSMMAXAMMMAMAMAS
        XSAMASXSSMMAAAMMMMMAAXSSSSMXMMSAMAMMMSSSMSASAAXMAAMXMASXMAAMASMMSSSXAASASMXXMMAMAXAMSMMXXMMMMMMSMMMSSSSSSSMMXSXMASMMSAMXMMMSAAAXMXXXAMSMMSAX
        XMAMXMXMXXSSSSMXAAMXMMMXAXAMXAAMMAMAAMMMAMAMMMMSSMMAMAMAMMMSASAMXAAMSXSXXMMMMMAMMMSMMAAAAMAMXMAAAAXMAAAAAXAXAMAMAXAAMASMSAAAASMAMMSXMMMAMMAM
        SSMMASASAMMMAXASMXSAAAXMSMMXMASMSXSMXXAMXMXMAXMAMXSSXXSXMXXMASMMMMMAXMMMAXAAMMSXXXMAXMMMASASAMSXXMMMMMMMMSMMSSMMSSMMSAMXSMSSMAXXXAAMSAMAMMXM
        MASXXSASAXAMXMMXAASMSMMAMAMAMAXAXASXXMAMXXXXXMMAXMMXAXSXSAXMASAMSSXMMAAASMSXSAMSAMSSMSSMXXASXMMMSSMXSXXAXAASAMXAAAAXMMSAXXAAMAMSMXSASASASMSM
        SAMXMMXMASXSMSXMSMXXXMXXXAMAMMXSMMMAMSSMMSSXSXSMSAAMXMMASMMMMSMMAAAXSMMXXXAAMAMAXMAMMAAMMMMMXMAAAAMAXMXMSSSMXSMMSSSMMMMMSMSSMMXSAAMMSAMASAXS
        MXMAASXMXMXAASMMMSSMMAASXSXMSAAXASMXMAAAAXXASAMAXMXMAAMAMMAAMMXMMMXMMSXMXMXSSMMMXMASMSXMAAAXASMMSSMSXSAMXXMAXSXMXAMAAXMAXAAMAMAMXMMAMAMAMAMX
        SSSSMMAMXMMMMMASAAMAXMMSAMXAMMXSAMXXMXSMMSMMMMMSMMMSSSMAXSSXSAAMXXAMXAXXMMXXMAAXASXMXXXSXSXMXSXAAAXMASXSMSMXMXAXMAMSSSSSMMMMAMASMXXSSMMSSXMM
        XMAMASXMMAAXXSAMMSSSMSXMAMMXMXMMMMXMSAMXAMXMAXXAAAAXMXXMMMAAAMMSSSMSMMXSASASMSMSMSAMXMASAMMSMXMMSSMMAMAMAAAASMMMSMMAAAAMMASXXSAXAMXAAAAAXASX
        XMASMSAMXSSSXMASAAMAASAMSMAAAXAAAAAAMASMMSASASXSSMSSXAXMASMMMASXAMSAAAASXMASAAXAMXXMAMSMAMAAAAMMXMAMASAMSMSMSAMAAAMMMMMMSASXAMXMSAMSSMMSSXMM
        MMXSXSXMAMAMXSSMMSSMMMXMAMSAMXSSSSXSAMXMSSXSXSAAXAXAMMMSASXXASAMXMXSSMXSSMXMMMSMSXASXSXMXMSMSASASXSSXSXMXAMMSXMSSSMSAMXXMASMSMXAXSAAAAXMMXMS
        """";

    [Fact]
    public void Test1() {
        string[] strings = [
            "XMASXXMASXXMASAMX", 
            "MAXSMAXSXMASXMASM"
            ];
        Program.CountHorizontal(strings).Should().Be(6);
    }

    [Fact]
    public void Test2() {
        string[] strings = [
            "XMSSXX",
            "MXMMXM",
            "AMAAXA",
            "SAXXXS",
            "MAXSMS"
            ];
        Program.CountVertical(strings).Should().Be(2);
    }

    [Fact]
    public void Test3() {
        string strings =
            @"..X...
              .SAMX.
              .A..A.
              XMAS.S
              .X....";
        Program.CountXMAS(strings).Should().Be(4);
    }

    [Fact]
    public void Test4() {
        string strings = 
            @"MMMSXXMASM
            MSAMXMSMSA
            AMXSXMAAMM
            MSAMASMSMX
            XMASAMXAMM
            XXAMMXXAMA
            SMSMSASXSS
            SAXAMASAAA
            MAMMMXMMMM
            MXMXAXMASX"
            ;
        Program.CountXMAS(strings).Should().Be(18);
    }

    [Fact]
    public void Answer1() {
        Program.CountXMAS(vals).Should().Be(2646);
    }

    [Fact]
    public void Test5() {
        string strings =
            @".M.S......
            ..A..MSMS.
            .M.S.MAA..
            ..A.ASMSM.
            .M.S.M....
            ..........
            S.S.S.S.S.
            .A.A.A.A..
            M.M.M.M.M.
            ..........";
        Program.CountX_MAS(strings).Should().Be(9);
    }

    [Fact]
    public void Answer2() {
        Program.CountX_MAS(vals).Should().Be(2000);
    }
}
