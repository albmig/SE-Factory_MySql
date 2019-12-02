using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Factory
{
    class GFunc
    {
        public static bool is433(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (codiceSistema.Substring(12, 1).ToUpper() == "B")
                return true;

            return false;
        }

        public static bool is868(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (codiceSistema.Substring(12, 1).ToUpper() == "X")
                return true;

            return false;
        }

        public static bool is915(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (codiceSistema.Substring(12, 1).ToUpper() == "A")
                return true;

            return false;
        }

        public static bool isCarOil(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (
                    (codiceSistema.StartsWith("XS"))
                    ||
                    (codiceSistema.StartsWith("XX"))
                    )
                    &&
                    (codiceSistema.Substring(7, 2).ToUpper() == "CA")
            )
                return true;

            return false;
        }

        public static bool isCradle(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                (codiceSistema.Substring(5, 1).ToUpper() == "P")
                &&
                (codiceSistema.StartsWith("XS17", 0))
            )
                return true;

            return false;
        }

        public static bool isPalm(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (codiceSistema.Substring(5, 1).ToUpper() == "P")
                return true;

            return false;
        }

        public static bool isCntr(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (codiceSistema.Substring(5, 1).ToUpper() == "R")
                return true;

            return false;
        }

        public static bool isEasy(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 1).ToUpper() == "P")
                    &&
                    (
                            (codiceSistema.StartsWith("XS20"))
                            ||
                            (codiceSistema.StartsWith("XS01"))
                            ||
                            (codiceSistema.StartsWith("XS10"))
                            ||
                            (codiceSistema.StartsWith("XS12"))
                    )
            )
                return true;

            return false;
        }

        public static bool isNimble(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 1).ToUpper() == "P")
                    &&
                    (codiceSistema.StartsWith("XS22")) // Nimble
            )
                return true;

            return false;
        }

        public static bool isNemo(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 1).ToUpper() == "P")
                    &&
                    (codiceSistema.StartsWith("XS38")) // Nemo
            )
                return true;

            return false;
        }

        public static bool isRescue(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 1).ToUpper() == "P")
                    &&
                    (
                            (codiceSistema.StartsWith("XS39")) // Rescue
                            ||
                            (codiceSistema.StartsWith("XS41")) // Rescue tipo Prolux
                    )
            )
                return true;

            return false;
        }

        public static bool isLift(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 1).ToUpper() == "P")
                    &&
                    (codiceSistema.StartsWith("XS40")) // Lift
            )
                return true;

            return false;
        }

        public static bool isBravo(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 1).ToUpper() == "P")
                    &&
                    (codiceSistema.StartsWith("XS42")) // Bravo
            )
                return true;
            else
                return false;
        }

        public static bool isPhilo(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 1).ToUpper() == "P")
                    &&
                    (codiceSistema.StartsWith("XS45")) // Philo
            )
                return true;
            else
                return false;
        }

        public static bool isEasyWire(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    ((codiceSistema.Substring(5, 1).ToUpper() == "P")
                    &&
                    (codiceSistema.StartsWith("XS24")))

                    ||

                    ((codiceSistema.Substring(5, 1).ToUpper() == "P")
                    &&
                    (codiceSistema.StartsWith("XS36")))

                    ||

                    ((codiceSistema.Substring(5, 1).ToUpper() == "P")
                    &&
                    (codiceSistema.StartsWith("XX04"))
                    &&
                    (codiceSistema.Substring(7, 4).ToUpper() == "KV01"))
            )
                return true;

            return false;
        }

        public static bool isTrend(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 1).ToUpper() == "P")
                    &&
                    (
                            (
                                    (codiceSistema.Substring(6, 1).ToUpper() != "A")
                                    &&
                                    (codiceSistema.Substring(6, 1).ToUpper() != "D")
                                    &&
                                    (codiceSistema.StartsWith("XS14"))
                            )
                            ||
                            (codiceSistema.StartsWith("XS04"))
                            ||
                            (codiceSistema.StartsWith("XS09"))
                            ||
                            (
                                    (codiceSistema.StartsWith("XX02"))
                                    &&
                                    (codiceSistema.Substring(7, 2).ToUpper() == "CT")
                            )
                            ||
                            (
                                    (codiceSistema.StartsWith("XX04"))
                                    &&
                                    (codiceSistema.Substring(7, 2).ToUpper() == "CT")
                            )
                            ||
                            (
                                    (codiceSistema.StartsWith("XX05"))
                                    &&
                                    (codiceSistema.Substring(7, 2).ToUpper() == "CT")
                            )
                    )

            )
                return true;

            return false;
        }

        public static bool isTrendB(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 2).ToUpper() == "PD")
                    &&
                    (codiceSistema.StartsWith("XS14"))
            )
                return true;

            return false;
        }

        public static bool isTrendLCD(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 2).ToUpper() == "PA")
                    &&
                    (codiceSistema.StartsWith("XS14"))
            )
                return true;

            return false;
        }

        public static bool isTrendWire(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 2).ToUpper() == "P")
                    &&
                    (codiceSistema.StartsWith("XS26"))
            )
                return true;

            return false;
        }

        public static bool isEasyXII(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 1).ToUpper() == "R")
                    &&
                    (codiceSistema.StartsWith("XS02"))
            )
                return true;

            return false;
        }

        public static bool isEasyXXI(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 1).ToUpper() == "R")
                    &&
                    (codiceSistema.StartsWith("XS11"))
            )
                return true;

            return false;
        }

        public static bool isCntr4(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 1).ToUpper() == "R")
                    &&
                    (
                            (codiceSistema.StartsWith("XS21"))
                            ||
                            (codiceSistema.StartsWith("XS05")) //Ripetitore MOOVEL
                    )
            )
                return true;

            return false;
        }

        public static bool isCntr8(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 1).ToUpper() == "R")
                    &&
                    (codiceSistema.StartsWith("XS20"))
            )
                return true;

            return false;
        }

        public static bool isCntr20(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 1).ToUpper() == "R")
                    &&
                    (codiceSistema.Substring(6, 1).ToUpper() != "E")
                    &&
                    (codiceSistema.Substring(6, 1).ToUpper() != "F")
                    &&
                    (codiceSistema.StartsWith("XS18"))
            )
                return true;

            return false;
        }

        public static bool isCntr20B(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (
                            (codiceSistema.Substring(5, 2).ToUpper() == "RE")
                            ||
                            (codiceSistema.Substring(6, 2).ToUpper() == "RF")
                    )
                    &&
                    (codiceSistema.StartsWith("XS18"))
            )
                return true;

            return false;
        }

        public static bool isCntr32(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 1).ToUpper() == "R")
                    &&
                    (codiceSistema.StartsWith("XS22"))
            )
                return true;

            return false;
        }

        public static bool isMulti12(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 1).ToUpper() == "R")
                    &&
                    (codiceSistema.StartsWith("XS19"))
            )
                return true;

            return false;
        }

        public static bool isPowerDrive12(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 2).ToUpper() == "RX")
                    &&
                    (codiceSistema.StartsWith("XS34"))
            )
                return true;

            return false;
        }

        public static bool isPowerDrive24(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 2).ToUpper() == "RA")
                    &&
                    (codiceSistema.StartsWith("XS34"))
            )
                return true;

            return false;
        }

        public static bool isPowerDrive12SW(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 2).ToUpper() == "RX")
                    &&
                    (codiceSistema.StartsWith("XX01"))
                    &&
                    (codiceSistema.Substring(7, 2).ToUpper() == "SW")
            )
                return true;

            return false;
        }

        public static bool isPowerDrive24SW(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 2).ToUpper() == "RA")
                    &&
                    (codiceSistema.StartsWith("XX01"))
                    &&
                    (codiceSistema.Substring(7, 2).ToUpper() == "SW")
            )
                return true;

            return false;
        }

        public static bool isCntrNimble(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 1).ToUpper() == "R")
                    &&
                    (
                            (codiceSistema.StartsWith("XS29"))
                            ||
                            (codiceSistema.StartsWith("XS30"))
                    )
            )
                return true;

            return false;
        }

        public static bool isCntrNimbleSW(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 1).ToUpper() == "R")
                    &&
                    (
                            (codiceSistema.StartsWith("XX02"))
                            &&
                            (codiceSistema.Substring(7, 2).ToUpper() == "SW")
                    )
            )
                return true;

            return false;
        }

        public static bool isCntr8AC(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 1).ToUpper() == "R")
                    &&
                    (codiceSistema.StartsWith("XS31"))
            )
                return true;

            return false;
        }

        public static bool isEasy_SL(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 1).ToUpper() == "P")
                    &&
                    (
                            (codiceSistema.StartsWith("XS47"))
                            ||
                            (codiceSistema.StartsWith("XS51"))
                    )
            )
                return true;

            return false;
        }

        public static bool isTrend_SL(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 1).ToUpper() == "P")
                    &&
                    (codiceSistema.StartsWith("XS46"))
            )
                return true;

            return false;
        }

        public static bool isSmartbox8_SL(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 1).ToUpper() == "R")
                    &&
                            (codiceSistema.StartsWith("XS49"))
                            ||
                            (codiceSistema.StartsWith("XS52"))
            )
                return true;

            return false;
        }

        public static bool isSmartbox20_SL(String codiceSistema)
        {
            if (codiceSistema == null)
                return false;

            if (
                    (codiceSistema.Substring(5, 1).ToUpper() == "R")
                    &&
                    codiceSistema.StartsWith("XS48")
            )
                return true;

            return false;
        }

    }
}
