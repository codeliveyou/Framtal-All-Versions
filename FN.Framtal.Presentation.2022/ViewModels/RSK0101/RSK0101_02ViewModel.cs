using System.ComponentModel;

namespace FN.Framtal.Presentation._2022.ViewModels
{
    public struct RSK101_2_LAUNATEKJUR_OG_STARFSTENGDAR_GREIÐSLUR_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string K101_LT_KT_GREIDANDI { get; set; }
        public string T101_LT_GREIDANDI { get; set; }
        public int N101_LT_GREIDSLA { get; set; }
        public string RSK_LT_UPPRUNI { get; set; }
        public string R101_LT_LAUNUPPRUNI { get; set; }

        public RSK101_2_LAUNATEKJUR_OG_STARFSTENGDAR_GREIÐSLUR_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _K101_LT_KT_GREIDANDI, string _T101_LT_GREIDANDI, int _N101_LT_GREIDSLA, string _RSK_LT_UPPRUNI, string _R101_LT_LAUNUPPRUNI)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            K101_LT_KT_GREIDANDI = _K101_LT_KT_GREIDANDI;
            T101_LT_GREIDANDI = _T101_LT_GREIDANDI;
            N101_LT_GREIDSLA = _N101_LT_GREIDSLA;
            RSK_LT_UPPRUNI = _RSK_LT_UPPRUNI;
            R101_LT_LAUNUPPRUNI = _R101_LT_LAUNUPPRUNI;
        }
    }
    public struct RSK101_2_BIFREIDAHLUNNINDI_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string K101_BH_KT_GREIDANDI { get; set; }
        public string T101_BH_GREIDANDI { get; set; }
        public int N101_BH_GREIDSLA { get; set; }
        public string RSK_BH_UPPRUNI { get; set; }

        public RSK101_2_BIFREIDAHLUNNINDI_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _K101_BH_KT_GREIDANDI, string _T101_BH_GREIDANDI, int _N101_BH_GREIDSLA, string _RSK_BH_UPPRUNI)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            K101_BH_KT_GREIDANDI = _K101_BH_KT_GREIDANDI;
            T101_BH_GREIDANDI = _T101_BH_GREIDANDI;
            N101_BH_GREIDSLA = _N101_BH_GREIDSLA;
            RSK_BH_UPPRUNI = _RSK_BH_UPPRUNI;
        }
    }
    public struct RSK101_2_HUSNAEDISHLUNNINDI_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string K101_HH_KT_GREIDANDI { get; set; }
        public string T101_HH_GREIDANDI { get; set; }
        public int N101_HH_GREIDSLA { get; set; }
        public string RSK_HH_UPPRUNI { get; set; }

        public RSK101_2_HUSNAEDISHLUNNINDI_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _K101_HH_KT_GREIDANDI, string _T101_HH_GREIDANDI, int _N101_HH_GREIDSLA, string _RSK_HH_UPPRUNI)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            K101_HH_KT_GREIDANDI = _K101_HH_KT_GREIDANDI;
            T101_HH_GREIDANDI = _T101_HH_GREIDANDI;
            N101_HH_GREIDSLA = _N101_HH_GREIDSLA;
            RSK_HH_UPPRUNI = _RSK_HH_UPPRUNI;
        }
    }
    public struct RSK101_2_ONNUR_HLUNNINDI_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string T101_HL_GREIDANDI { get; set; }
        public int N101_HL_GREIDSLA { get; set; }
        public string RSK_HL_UPPRUNI { get; set; }
        public string K101_HL_KT_GREIDANDI { get; set; }
        public string T101_HL_TEGUND_HLUNNINDA { get; set; }

        public RSK101_2_ONNUR_HLUNNINDI_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _T101_HL_GREIDANDI, int _N101_HL_GREIDSLA, string _RSK_HL_UPPRUNI, string _K101_HL_KT_GREIDANDI, string _T101_HL_TEGUND_HLUNNINDA)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            T101_HL_GREIDANDI = _T101_HL_GREIDANDI;
            N101_HL_GREIDSLA = _N101_HL_GREIDSLA;
            RSK_HL_UPPRUNI = _RSK_HL_UPPRUNI;
            K101_HL_KT_GREIDANDI = _K101_HL_KT_GREIDANDI;
            T101_HL_TEGUND_HLUNNINDA = _T101_HL_TEGUND_HLUNNINDA;
        }
    }
    public struct RSK101_2_GREIDSL_UR_LIFEYRISS_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string K101_GL_KT_GREIDANDI { get; set; }
        public string T101_GL_GREIDANDI { get; set; }
        public int N101_GL_GREIDSLA { get; set; }
        public string RSK_GL_UPPRUNI { get; set; }

        public RSK101_2_GREIDSL_UR_LIFEYRISS_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _K101_GL_KT_GREIDANDI, string _T101_GL_GREIDANDI, int _N101_GL_GREIDSLA, string _RSK_GL_UPPRUNI)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            K101_GL_KT_GREIDANDI = _K101_GL_KT_GREIDANDI;
            T101_GL_GREIDANDI = _T101_GL_GREIDANDI;
            N101_GL_GREIDSLA = _N101_GL_GREIDSLA;
            RSK_GL_UPPRUNI = _RSK_GL_UPPRUNI;
        }
    }
    public struct RSK101_2_GREIDSL_UR_SEREIGNSJ_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string K101_GS_KT_GREIDANDI { get; set; }
        public string T101_GS_GREIDANDI { get; set; }
        public int N101_GS_GREIDSLA { get; set; }
        public string RSK_GS_UPPRUNI { get; set; }

        public RSK101_2_GREIDSL_UR_SEREIGNSJ_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _K101_GS_KT_GREIDANDI, string _T101_GS_GREIDANDI, int _N101_GS_GREIDSLA, string _RSK_GS_UPPRUNI)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            K101_GS_KT_GREIDANDI = _K101_GS_KT_GREIDANDI;
            T101_GS_GREIDANDI = _T101_GS_GREIDANDI;
            N101_GS_GREIDSLA = _N101_GS_GREIDSLA;
            RSK_GS_UPPRUNI = _RSK_GS_UPPRUNI;
        }
    }
    public struct RSK101_2_SER_GR_UR_SEREIGNSJ_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string K101_US_KT_GREIDANDI { get; set; }
        public string T101_US_GREIDANDI { get; set; }
        public int N101_US_GREIDSLA { get; set; }
        public string RSK_US_UPPRUNI { get; set; }

        public RSK101_2_SER_GR_UR_SEREIGNSJ_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _K101_US_KT_GREIDANDI, string _T101_US_GREIDANDI, int _N101_US_GREIDSLA, string _RSK_US_UPPRUNI)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            K101_US_KT_GREIDANDI = _K101_US_KT_GREIDANDI;
            T101_US_GREIDANDI = _T101_US_GREIDANDI;
            N101_US_GREIDSLA = _N101_US_GREIDSLA;
            RSK_US_UPPRUNI = _RSK_US_UPPRUNI;
        }
    }
    public struct RSK101_2_ATVINNULEYSISBAETUR_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string K101_AB_KT_GREIDANDI { get; set; }
        public string T101_AB_GREIDANDI { get; set; }
        public int N101_AB_GREIDSLA { get; set; }
        public string RSK_AB_UPPRUNI { get; set; }

        public RSK101_2_ATVINNULEYSISBAETUR_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _K101_AB_KT_GREIDANDI, string _T101_AB_GREIDANDI, int _N101_AB_GREIDSLA, string _RSK_AB_UPPRUNI)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            K101_AB_KT_GREIDANDI = _K101_AB_KT_GREIDANDI;
            T101_AB_GREIDANDI = _T101_AB_GREIDANDI;
            N101_AB_GREIDSLA = _N101_AB_GREIDSLA;
            RSK_AB_UPPRUNI = _RSK_AB_UPPRUNI;
        }
    }
    public struct RSK101_2_FELAGSLEG_ADSTOD_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string K101_FS_KT_GREIDANDI { get; set; }
        public string T101_FS_GREIDANDI { get; set; }
        public int N101_FS_GREIDSLA { get; set; }
        public string RSK_FS_UPPRUNI { get; set; }

        public RSK101_2_FELAGSLEG_ADSTOD_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _K101_FS_KT_GREIDANDI, string _T101_FS_GREIDANDI, int _N101_FS_GREIDSLA, string _RSK_FS_UPPRUNI)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            K101_FS_KT_GREIDANDI = _K101_FS_KT_GREIDANDI;
            T101_FS_GREIDANDI = _T101_FS_GREIDANDI;
            N101_FS_GREIDSLA = _N101_FS_GREIDSLA;
            RSK_FS_UPPRUNI = _RSK_FS_UPPRUNI;
        }
    }
    public struct RSK101_2_STYRKIR_TIL_NAMS_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string K101_SN_KT_GREIDANDI { get; set; }
        public string T101_SN_GREIDANDI { get; set; }
        public int N101_SN_GREIDSLA { get; set; }
        public string RSK_SN_UPPRUNI { get; set; }

        public RSK101_2_STYRKIR_TIL_NAMS_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _K101_SN_KT_GREIDANDI, string _T101_SN_GREIDANDI, int _N101_SN_GREIDSLA, string _RSK_SN_UPPRUNI)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            K101_SN_KT_GREIDANDI = _K101_SN_KT_GREIDANDI;
            T101_SN_GREIDANDI = _T101_SN_GREIDANDI;
            N101_SN_GREIDSLA = _N101_SN_GREIDSLA;
            RSK_SN_UPPRUNI = _RSK_SN_UPPRUNI;
        }
    }
    public struct RSK101_2_ANNAD_HVAD_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string K101_AH_KT_GREIDANDI { get; set; }
        public string T101_AH_GREIDANDI { get; set; }
        public int N101_AH_RSK_KODI { get; set; }
        public int N101_AH_GREIDSLA { get; set; }
        public string RSK_AH_UPPRUNI { get; set; }
        public string T101_AH_TEGUND_TEKNA { get; set; }

        public RSK101_2_ANNAD_HVAD_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _K101_AH_KT_GREIDANDI, string _T101_AH_GREIDANDI, int _N101_AH_RSK_KODI, int _N101_AH_GREIDSLA, string _RSK_AH_UPPRUNI, string _T101_AH_TEGUND_TEKNA)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            K101_AH_KT_GREIDANDI = _K101_AH_KT_GREIDANDI;
            T101_AH_GREIDANDI = _T101_AH_GREIDANDI;
            N101_AH_RSK_KODI = _N101_AH_RSK_KODI;
            N101_AH_GREIDSLA = _N101_AH_GREIDSLA;
            RSK_AH_UPPRUNI = _RSK_AH_UPPRUNI;
            T101_AH_TEGUND_TEKNA = _T101_AH_TEGUND_TEKNA;
        }
    }
    public struct RSK101_2_LIFEYRISIDGJALD_SAM_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string K101_LA_KT_GREIDANDI { get; set; }
        public string T101_LA_GREIDANDI { get; set; }
        public int N101_LA_GREIDSLA { get; set; }
        public string RSK_LA_UPPRUNI { get; set; }
        public RSK101_2_LIFEYRISIDGJALD_SAM_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _K101_LA_KT_GREIDANDI, string _T101_LA_GREIDANDI, int _N101_LA_GREIDSLA, string _RSK_LA_UPPRUNI)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            K101_LA_KT_GREIDANDI = _K101_LA_KT_GREIDANDI;
            T101_LA_GREIDANDI = _T101_LA_GREIDANDI;
            N101_LA_GREIDSLA = _N101_LA_GREIDSLA;
            RSK_LA_UPPRUNI = _RSK_LA_UPPRUNI;
        }
    }
    public struct RSK101_2_LIFEYRISIDGJALD_SER_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string K101_LE_KT_GREIDANDI { get; set; }
        public string T101_LE_GREIDANDI { get; set; }
        public int N101_LE_GREIDSLA { get; set; }
        public string RSK_LE_UPPRUNI { get; set; }
        public RSK101_2_LIFEYRISIDGJALD_SER_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _K101_LE_KT_GREIDANDI, string _T101_LE_GREIDANDI, int _N101_LE_GREIDSLA, string _RSK_LE_UPPRUNI)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            K101_LE_KT_GREIDANDI = _K101_LE_KT_GREIDANDI;
            T101_LE_GREIDANDI = _T101_LE_GREIDANDI;
            N101_LE_GREIDSLA = _N101_LE_GREIDSLA;
            RSK_LE_UPPRUNI = _RSK_LE_UPPRUNI;
        }
    }
    public struct RSK101_2_FRADR_NAMSSTYRKIR_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string T101_FN_SKYRING { get; set; }
        public int N101_FN_GREIDSLA { get; set; }
        public RSK101_2_FRADR_NAMSSTYRKIR_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _T101_FN_SKYRING, int _N101_FN_GREIDSLA)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            T101_FN_SKYRING = _T101_FN_SKYRING;
            N101_FN_GREIDSLA = _N101_FN_GREIDSLA;
        }
    }
    public struct RSK101_2_FRADR_ANNAR_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string T101_FA_SKYRING { get; set; }
        public int N101_FA_GREIDSLA { get; set; }
        public RSK101_2_FRADR_ANNAR_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _T101_FA_SKYRING, int _N101_FA_GREIDSLA)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            T101_FA_SKYRING = _T101_FA_SKYRING;
            N101_FA_GREIDSLA = _N101_FA_GREIDSLA;
        }
    }
    public struct RSK101_2_TEKJUR_ERLENDIS_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string T101_TE_RSK_R525 { get; set; }
        public int N101_TE_ERLEND_MYNT { get; set; }
        public int N101_TE_ISL_KR { get; set; }
        public string T101_TE_GJALDMIDILL { get; set; }
        public string R101_TE_LAND { get; set; }
        public int N101_GREIDDIR_SKATTAR_ERLENDIS { get; set; }
        public string R101_TE_TEGUND_TEKNA { get; set; }
        public int N101_TE_GENGI { get; set; }
        public int N101_TE_TIMABIL { get; set; }
        public string RSK_TE_UPPRUNI { get; set; }
        public string T101_TE_GREIDANDI { get; set; }
        public string T101_TE_SERST_TEGUND_TEKNA { get; set; }

        public RSK101_2_TEKJUR_ERLENDIS_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _T101_TE_RSK_R525, int _N101_TE_ERLEND_MYNT, int _N101_TE_ISL_KR, string _T101_TE_GJALDMIDILL, string _R101_TE_LAND, int _N101_GREIDDIR_SKATTAR_ERLENDIS, string _R101_TE_TEGUND_TEKNA, int _N101_TE_GENGI, int _N101_TE_TIMABIL, string _RSK_TE_UPPRUNI, string _T101_TE_GREIDANDI, string _T101_TE_SERST_TEGUND_TEKNA)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            T101_TE_RSK_R525 = _T101_TE_RSK_R525;
            N101_TE_ERLEND_MYNT = _N101_TE_ERLEND_MYNT;
            N101_TE_ISL_KR = _N101_TE_ISL_KR;
            T101_TE_GJALDMIDILL = _T101_TE_GJALDMIDILL;
            R101_TE_LAND = _R101_TE_LAND;
            N101_GREIDDIR_SKATTAR_ERLENDIS = _N101_GREIDDIR_SKATTAR_ERLENDIS;
            R101_TE_TEGUND_TEKNA = _R101_TE_TEGUND_TEKNA;
            N101_TE_GENGI = _N101_TE_GENGI;
            N101_TE_TIMABIL = _N101_TE_TIMABIL;
            RSK_TE_UPPRUNI = _RSK_TE_UPPRUNI;
            T101_TE_GREIDANDI = _T101_TE_GREIDANDI;
            T101_TE_SERST_TEGUND_TEKNA = _T101_TE_SERST_TEGUND_TEKNA;
        }
    }
    public struct RSK101_2_SKATTFR_VINNINGAR_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string K101_SV_KT_GREIDANDI { get; set; }
        public string T101_SV_GREIDANDI { get; set; }
        public int N101_SV_GREIDSLA { get; set; }
        public string RSK_SV_UPPRUNI { get; set; }

        public RSK101_2_SKATTFR_VINNINGAR_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _K101_SV_KT_GREIDANDI, string _T101_SV_GREIDANDI, int _N101_SV_GREIDSLA, string _RSK_SV_UPPRUNI)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            K101_SV_KT_GREIDANDI = _K101_SV_KT_GREIDANDI;
            T101_SV_GREIDANDI = _T101_SV_GREIDANDI;
            N101_SV_GREIDSLA = _N101_SV_GREIDSLA;
            RSK_SV_UPPRUNI = _RSK_SV_UPPRUNI;
        }
    }
    public struct RSK101_2_ADRAR_SKATTFR_TEKJUR_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string K101_AT_KT_GREIDANDI { get; set; }
        public string T101_AT_GREIDANDI { get; set; }
        public string T101_AT_TEGUND_TEKNA { get; set; }
        public int N101_AT_GREIDSLA { get; set; }
        public string RSK_AT_UPPRUNI { get; set; }

        public RSK101_2_ADRAR_SKATTFR_TEKJUR_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _K101_AT_KT_GREIDANDI, string _T101_AT_GREIDANDI, string _T101_AT_TEGUND_TEKNA, int _N101_AT_GREIDSLA, string _RSK_AT_UPPRUNI)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            K101_AT_KT_GREIDANDI = _K101_AT_KT_GREIDANDI;
            T101_AT_GREIDANDI = _T101_AT_GREIDANDI;
            T101_AT_TEGUND_TEKNA = _T101_AT_TEGUND_TEKNA;
            N101_AT_GREIDSLA = _N101_AT_GREIDSLA;
            RSK_AT_UPPRUNI = _RSK_AT_UPPRUNI;
        }
    }

    public class RSK0101_02ViewModel : ViewModelBase
    {
        BindingList<RSK101_2_LAUNATEKJUR_OG_STARFSTENGDAR_GREIÐSLUR_ITEM> _RSK101_2_LAUNATEKJUR_OG_STARFSTENGDAR_GREIÐSLUR;
        BindingList<RSK101_2_BIFREIDAHLUNNINDI_ITEM> _RSK101_2_BIFREIDAHLUNNINDI;
        BindingList<RSK101_2_HUSNAEDISHLUNNINDI_ITEM> _RSK101_2_HUSNAEDISHLUNNINDI;
        BindingList<RSK101_2_ONNUR_HLUNNINDI_ITEM> _RSK101_2_ONNUR_HLUNNINDI;
        BindingList<RSK101_2_GREIDSL_UR_LIFEYRISS_ITEM> _RSK101_2_GREIDSL_UR_LIFEYRISS;
        BindingList<RSK101_2_GREIDSL_UR_SEREIGNSJ_ITEM> _RSK101_2_GREIDSL_UR_SEREIGNSJ;
        BindingList<RSK101_2_SER_GR_UR_SEREIGNSJ_ITEM> _RSK101_2_SER_GR_UR_SEREIGNSJ;
        BindingList<RSK101_2_ATVINNULEYSISBAETUR_ITEM> _RSK101_2_ATVINNULEYSISBAETUR;
        BindingList<RSK101_2_FELAGSLEG_ADSTOD_ITEM> _RSK101_2_FELAGSLEG_ADSTOD;
        BindingList<RSK101_2_STYRKIR_TIL_NAMS_ITEM> _RSK101_2_STYRKIR_TIL_NAMS;
        BindingList<RSK101_2_ANNAD_HVAD_ITEM> _RSK101_2_ANNAD_HVAD;
        BindingList<RSK101_2_LIFEYRISIDGJALD_SAM_ITEM> _RSK101_2_LIFEYRISIDGJALD_SAM;
        BindingList<RSK101_2_LIFEYRISIDGJALD_SER_ITEM> _RSK101_2_LIFEYRISIDGJALD_SER;
        BindingList<RSK101_2_FRADR_NAMSSTYRKIR_ITEM> _RSK101_2_FRADR_NAMSSTYRKIR;
        BindingList<RSK101_2_FRADR_ANNAR_ITEM> _RSK101_2_FRADR_ANNAR;

        BindingList<RSK101_2_TEKJUR_ERLENDIS_ITEM> _RSK101_2_TEKJUR_ERLENDIS;
        BindingList<RSK101_2_SKATTFR_VINNINGAR_ITEM> _RSK101_2_SKATTFR_VINNINGAR;
        BindingList<RSK101_2_ADRAR_SKATTFR_TEKJUR_ITEM> _RSK101_2_ADRAR_SKATTFR_TEKJUR;

        public BindingList<RSK101_2_LAUNATEKJUR_OG_STARFSTENGDAR_GREIÐSLUR_ITEM> RSK101_2_LAUNATEKJUR_OG_STARFSTENGDAR_GREIÐSLUR
        {
            get
            {
                return _RSK101_2_LAUNATEKJUR_OG_STARFSTENGDAR_GREIÐSLUR;
            }
            set
            {
                _RSK101_2_LAUNATEKJUR_OG_STARFSTENGDAR_GREIÐSLUR = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_2_BIFREIDAHLUNNINDI_ITEM> RSK101_2_BIFREIDAHLUNNINDI
        {
            get
            {
                return _RSK101_2_BIFREIDAHLUNNINDI;
            }
            set
            {
                _RSK101_2_BIFREIDAHLUNNINDI = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_2_HUSNAEDISHLUNNINDI_ITEM> RSK101_2_HUSNAEDISHLUNNINDI
        {
            get
            {
                return _RSK101_2_HUSNAEDISHLUNNINDI;
            }
            set
            {
                _RSK101_2_HUSNAEDISHLUNNINDI = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_2_ONNUR_HLUNNINDI_ITEM> RSK101_2_ONNUR_HLUNNINDI
        {
            get
            {
                return _RSK101_2_ONNUR_HLUNNINDI;
            }
            set
            {
                _RSK101_2_ONNUR_HLUNNINDI = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_2_GREIDSL_UR_LIFEYRISS_ITEM> RSK101_2_GREIDSL_UR_LIFEYRISS
        {
            get
            {
                return _RSK101_2_GREIDSL_UR_LIFEYRISS;
            }
            set
            {
                _RSK101_2_GREIDSL_UR_LIFEYRISS = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_2_GREIDSL_UR_SEREIGNSJ_ITEM> RSK101_2_GREIDSL_UR_SEREIGNSJ
        {
            get
            {
                return _RSK101_2_GREIDSL_UR_SEREIGNSJ;
            }
            set
            {
                _RSK101_2_GREIDSL_UR_SEREIGNSJ = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_2_SER_GR_UR_SEREIGNSJ_ITEM> RSK101_2_SER_GR_UR_SEREIGNSJ
        {
            get
            {
                return _RSK101_2_SER_GR_UR_SEREIGNSJ;
            }
            set
            {
                _RSK101_2_SER_GR_UR_SEREIGNSJ = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_2_ATVINNULEYSISBAETUR_ITEM> RSK101_2_ATVINNULEYSISBAETUR
        {
            get
            {
                return _RSK101_2_ATVINNULEYSISBAETUR;
            }
            set
            {
                _RSK101_2_ATVINNULEYSISBAETUR = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_2_FELAGSLEG_ADSTOD_ITEM> RSK101_2_FELAGSLEG_ADSTOD
        {
            get
            {
                return _RSK101_2_FELAGSLEG_ADSTOD;
            }
            set
            {
                _RSK101_2_FELAGSLEG_ADSTOD = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_2_STYRKIR_TIL_NAMS_ITEM> RSK101_2_STYRKIR_TIL_NAMS
        {
            get
            {
                return _RSK101_2_STYRKIR_TIL_NAMS;
            }
            set
            {
                _RSK101_2_STYRKIR_TIL_NAMS = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_2_ANNAD_HVAD_ITEM> RSK101_2_ANNAD_HVAD
        {
            get
            {
                return _RSK101_2_ANNAD_HVAD;
            }
            set
            {
                _RSK101_2_ANNAD_HVAD = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_2_LIFEYRISIDGJALD_SAM_ITEM> RSK101_2_LIFEYRISIDGJALD_SAM
        {
            get
            {
                return _RSK101_2_LIFEYRISIDGJALD_SAM;
            }
            set
            {
                _RSK101_2_LIFEYRISIDGJALD_SAM = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_2_LIFEYRISIDGJALD_SER_ITEM> RSK101_2_LIFEYRISIDGJALD_SER
        {
            get
            {
                return _RSK101_2_LIFEYRISIDGJALD_SER;
            }
            set
            {
                _RSK101_2_LIFEYRISIDGJALD_SER = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_2_FRADR_NAMSSTYRKIR_ITEM> RSK101_2_FRADR_NAMSSTYRKIR
        {
            get
            {
                return _RSK101_2_FRADR_NAMSSTYRKIR;
            }
            set
            {
                _RSK101_2_FRADR_NAMSSTYRKIR = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_2_FRADR_ANNAR_ITEM> RSK101_2_FRADR_ANNAR
        {
            get
            {
                return _RSK101_2_FRADR_ANNAR;
            }
            set
            {
                _RSK101_2_FRADR_ANNAR = value;
                OnPropertyChanged();
            }
        }

        public BindingList<RSK101_2_TEKJUR_ERLENDIS_ITEM> RSK101_2_TEKJUR_ERLENDIS
        {
            get
            {
                return _RSK101_2_TEKJUR_ERLENDIS;
            }
            set
            {
                _RSK101_2_TEKJUR_ERLENDIS = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_2_SKATTFR_VINNINGAR_ITEM> RSK101_2_SKATTFR_VINNINGAR
        {
            get
            {
                return _RSK101_2_SKATTFR_VINNINGAR;
            }
            set
            {
                _RSK101_2_SKATTFR_VINNINGAR = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_2_ADRAR_SKATTFR_TEKJUR_ITEM> RSK101_2_ADRAR_SKATTFR_TEKJUR
        {
            get
            {
                return _RSK101_2_ADRAR_SKATTFR_TEKJUR;
            }
            set
            {
                _RSK101_2_ADRAR_SKATTFR_TEKJUR = value;
                OnPropertyChanged();
            }
        }

        public RSK0101_02ViewModel()
        {
        }
    }
}