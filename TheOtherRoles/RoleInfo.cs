using System.Linq;
using System;
using System.Collections.Generic;
using TheOtherRoles.Players;
using static TheOtherRoles.TheOtherRoles;
using UnityEngine;
using TheOtherRoles.Utilities;
using TheOtherRoles.CustomGameModes;
using System.Threading.Tasks;
using System.Net.Http;

namespace TheOtherRoles
{
    public class RoleInfo {
        public Color color;
        public string name;
        public string introDescription;
        public string shortDescription;
        public RoleId roleId;
        public bool isNeutral;
        public bool isModifier;

        public RoleInfo(string name, Color color, string introDescription, string shortDescription, RoleId roleId, bool isNeutral = false, bool isModifier = false) {
            this.color = color;
            this.name = name;
            this.introDescription = introDescription;
            this.shortDescription = shortDescription;
            this.roleId = roleId;
            this.isNeutral = isNeutral;
            this.isModifier = isModifier;
        }

        public static RoleInfo jester = new RoleInfo(Lang.Get("JesterName"), Jester.color, Lang.Get("JesterIntroDesc"), Lang.Get("JesterShortDesc"), RoleId.Jester, true);
        public static RoleInfo mayor = new RoleInfo(Lang.Get("MayorName"), Mayor.color, Lang.Get("MayorIntroDesc"), Lang.Get("MayorShortDesc"), RoleId.Mayor);
        public static RoleInfo portalmaker = new RoleInfo(Lang.Get("PortalmakerName"), Portalmaker.color, Lang.Get("PortalmakerIntroDesc"), Lang.Get("PortalmakerShortDesc"), RoleId.Portalmaker);
        public static RoleInfo engineer = new RoleInfo(Lang.Get("EngineerName"), Engineer.color, Lang.Get("EngineerIntroDesc"), Lang.Get("EngineerShortDesc"), RoleId.Engineer);
        public static RoleInfo sheriff = new RoleInfo(Lang.Get("SheriffName"), Sheriff.color, Lang.Get("SheriffIntroDesc"), Lang.Get("SheriffShortDesc"), RoleId.Sheriff);
        public static RoleInfo deputy = new RoleInfo(Lang.Get("DeputyName"), Sheriff.color, Lang.Get("DeputyIntroDesc"), Lang.Get("DeputyShortDesc"), RoleId.Deputy);
        public static RoleInfo lighter = new RoleInfo(Lang.Get("LighterName"), Lighter.color, Lang.Get("LighterIntroDesc"), Lang.Get("LighterShortDesc"), RoleId.Lighter);
        public static RoleInfo godfather = new RoleInfo(Lang.Get("GodfatherName"), Godfather.color, Lang.Get("GodfatherIntroDesc"), Lang.Get("GodfatherShortDesc"), RoleId.Godfather);
        public static RoleInfo mafioso = new RoleInfo(Lang.Get("MafiosoName"), Mafioso.color, Lang.Get("MafiosoIntroDesc"), Lang.Get("MafiosoShortDesc"), RoleId.Mafioso);
        public static RoleInfo janitor = new RoleInfo(Lang.Get("JanitorName"), Janitor.color, Lang.Get("JanitorIntroDesc"), Lang.Get("JanitorShortDesc"), RoleId.Janitor);
        public static RoleInfo morphling = new RoleInfo(Lang.Get("MorphlingName"), Morphling.color, Lang.Get("MorphlingIntroDesc"), Lang.Get("MorphlingShortDesc"), RoleId.Morphling);
        public static RoleInfo camouflager = new RoleInfo(Lang.Get("CamouflagerName"), Camouflager.color, Lang.Get("CamouflagerIntroDesc"), Lang.Get("CamouflagerShortDesc"), RoleId.Camouflager);
        public static RoleInfo vampire = new RoleInfo(Lang.Get("VampireName"), Vampire.color, Lang.Get("VampireIntroDesc"), Lang.Get("VampireShortDesc"), RoleId.Vampire);
        public static RoleInfo eraser = new RoleInfo(Lang.Get("EraserName"), Eraser.color, Lang.Get("EraserIntroDesc"), Lang.Get("EraserShortDesc"), RoleId.Eraser);
        public static RoleInfo trickster = new RoleInfo(Lang.Get("TricksterName"), Trickster.color, Lang.Get("TricksterIntroDesc"), Lang.Get("TricksterShortDesc"), RoleId.Trickster);
        public static RoleInfo cleaner = new RoleInfo(Lang.Get("CleanerName"), Cleaner.color, Lang.Get("CleanerIntroDesc"), Lang.Get("CleanerShortDesc"), RoleId.Cleaner);
        public static RoleInfo warlock = new RoleInfo(Lang.Get("WarlockName"), Warlock.color, Lang.Get("WarlockIntroDesc"), Lang.Get("WarlockShortDesc"), RoleId.Warlock);
        public static RoleInfo bountyHunter = new RoleInfo(Lang.Get("BountyHunterName"), BountyHunter.color, Lang.Get("BountyHunterIntroDesc"), Lang.Get("BountyHunterShortDesc"), RoleId.BountyHunter);
        public static RoleInfo detective = new RoleInfo(Lang.Get("DetectiveName"), Detective.color, Lang.Get("DetectiveIntroDesc"), Lang.Get("DetectiveShortDesc"), RoleId.Detective);
        public static RoleInfo timeMaster = new RoleInfo(Lang.Get("TimeMasterName"), TimeMaster.color, Lang.Get("TimeMasterIntroDesc"), Lang.Get("TimeMasterShortDesc"), RoleId.TimeMaster);
        public static RoleInfo medic = new RoleInfo(Lang.Get("MedicName"), Medic.color, Lang.Get("MedicIntroDesc"), Lang.Get("MedicShortDesc"), RoleId.Medic);
        public static RoleInfo swapper = new RoleInfo(Lang.Get("SwapperName"), Swapper.color, Lang.Get("SwapperIntroDesc"), Lang.Get("SwapperShortDesc"), RoleId.Swapper);
        public static RoleInfo seer = new RoleInfo(Lang.Get("SeerName"), Seer.color, Lang.Get("SeerIntroDesc"), Lang.Get("SeerShortDesc"), RoleId.Seer);
        public static RoleInfo hacker = new RoleInfo(Lang.Get("HackerName"), Hacker.color, Lang.Get("HackerIntroDesc"), Lang.Get("HackerShortDesc"), RoleId.Hacker);
        public static RoleInfo tracker = new RoleInfo(Lang.Get("TrackerName"), Tracker.color, Lang.Get("TrackerIntroDesc"), Lang.Get("TrackerShortDesc"), RoleId.Tracker);
        public static RoleInfo snitch = new RoleInfo(Lang.Get("SnitchName"), Snitch.color, Lang.Get("SnitchIntroDesc"), Lang.Get("SnitchShortDesc"), RoleId.Snitch);
        public static RoleInfo jackal = new RoleInfo(Lang.Get("JackalName"), Jackal.color, Lang.Get("JackalIntroDesc"), Lang.Get("JackalShortDesc"), RoleId.Jackal, true);
        public static RoleInfo sidekick = new RoleInfo(Lang.Get("SidekickName"), Sidekick.color, Lang.Get("SidekickIntroDesc"), Lang.Get("SidekickShortDesc"), RoleId.Sidekick, true);
        public static RoleInfo spy = new RoleInfo(Lang.Get("SpyName"), Spy.color, Lang.Get("SpyIntroDesc"), Lang.Get("SpyShortDesc"), RoleId.Spy);
        public static RoleInfo securityGuard = new RoleInfo(Lang.Get("SecurityGuardName"), SecurityGuard.color, Lang.Get("SecurityGuardIntroDesc"), Lang.Get("SecurityGuardShortDesc"), RoleId.SecurityGuard);
        public static RoleInfo arsonist = new RoleInfo(Lang.Get("ArsonistName"), Arsonist.color, Lang.Get("ArsonistIntroDesc"), Lang.Get("ArsonistShortDesc"), RoleId.Arsonist, true);
        public static RoleInfo goodGuesser = new RoleInfo(Lang.Get("NiceGuesserName"), Guesser.color, Lang.Get("NiceGuesserIntroDesc"), Lang.Get("NiceGuesserShortDesc"), RoleId.NiceGuesser);
        public static RoleInfo badGuesser = new RoleInfo(Lang.Get("EvilGuesserName"), Palette.ImpostorRed, Lang.Get("EvilGuesserIntroDesc"), Lang.Get("EvilGuesserShortDesc"), RoleId.EvilGuesser);
        public static RoleInfo vulture = new RoleInfo(Lang.Get("VultureName"), Vulture.color, Lang.Get("VultureIntroDesc"), Lang.Get("VultureShortDesc"), RoleId.Vulture, true);
        public static RoleInfo medium = new RoleInfo(Lang.Get("MediumName"), Medium.color, Lang.Get("MediumIntroDesc"), Lang.Get("MediumShortDesc"), RoleId.Medium);
        public static RoleInfo trapper = new RoleInfo(Lang.Get("TrapperName"), Trapper.color, Lang.Get("TrapperIntroDesc"), Lang.Get("TrapperShortDesc"), RoleId.Trapper);
        public static RoleInfo lawyer = new RoleInfo(Lang.Get("LawyerName"), Lawyer.color, Lang.Get("LawyerIntroDesc"), Lang.Get("LawyerShortDesc"), RoleId.Lawyer, true);
        public static RoleInfo prosecutor = new RoleInfo(Lang.Get("ProsecutorName"), Lawyer.color, Lang.Get("ProsecutorIntroDesc"), Lang.Get("ProsecutorShortDesc"), RoleId.Prosecutor, true);
        public static RoleInfo pursuer = new RoleInfo(Lang.Get("PursuerName"), Pursuer.color, Lang.Get("PursuerIntroDesc"), Lang.Get("PursuerShortDesc"), RoleId.Pursuer);
        public static RoleInfo impostor = new RoleInfo(Lang.Get("ImpostorName"), Palette.ImpostorRed, Helpers.cs(Palette.ImpostorRed,  Lang.Get("ImpostorIntroDesc")), Lang.Get("ImpostorShortDesc"), RoleId.Impostor);
        public static RoleInfo crewmate = new RoleInfo(Lang.Get("CrewmateName"), Color.white, Lang.Get("CrewmateIntroDesc"), Lang.Get("CrewmateShortDesc"), RoleId.Crewmate);
        public static RoleInfo witch = new RoleInfo(Lang.Get("WitchName"), Witch.color, Lang.Get("WitchIntroDesc"), Lang.Get("WitchShortDesc"), RoleId.Witch);
        public static RoleInfo ninja = new RoleInfo(Lang.Get("NinjaName"), Ninja.color, Lang.Get("NinjaIntroDesc"), Lang.Get("NinjaShortDesc"), RoleId.Ninja);
        public static RoleInfo thief = new RoleInfo(Lang.Get("ThiefName"), Thief.color, Lang.Get("ThiefIntroDesc"), Lang.Get("ThiefShortDesc"), RoleId.Thief, true);
        public static RoleInfo bomber = new RoleInfo(Lang.Get("BomberName"), Bomber.color, Lang.Get("BomberIntroDesc"), Lang.Get("BomberShortDesc"), RoleId.Bomber);

        public static RoleInfo hunter = new RoleInfo(Lang.Get("HunterName"), Palette.ImpostorRed, Helpers.cs(Palette.ImpostorRed, Lang.Get("HunterIntroDesc")), Lang.Get("HunterShortDesc"), RoleId.Impostor);
        public static RoleInfo hunted = new RoleInfo(Lang.Get("HuntedName"), Color.white, Lang.Get("HuntedIntroDesc"), Lang.Get("HuntedShortDesc"), RoleId.Crewmate);

        public static RoleInfo prop = new RoleInfo(Lang.Get("PropName"), Color.white, Lang.Get("PropIntroDesc"), Lang.Get("PropShortDesc"), RoleId.Crewmate);



        // Modifier
        public static RoleInfo bloody = new RoleInfo(Lang.Get("BloodyName"), Color.yellow, Lang.Get("BloodyIntroDesc"), Lang.Get("BloodyShortDesc"), RoleId.Bloody, false, true);
        public static RoleInfo antiTeleport = new RoleInfo(Lang.Get("AntiTPName"), Color.yellow, Lang.Get("AntiTPIntroDesc"), Lang.Get("AntiTPShortDesc"), RoleId.AntiTeleport, false, true);
        public static RoleInfo tiebreaker = new RoleInfo(Lang.Get("TiebreakerName"), Color.yellow, Lang.Get("TiebreakerIntroDesc"), Lang.Get("TiebreakerShortDesc"), RoleId.Tiebreaker, false, true);
        public static RoleInfo bait = new RoleInfo(Lang.Get("BaitName"), Color.yellow, Lang.Get("BaitIntroDesc"), Lang.Get("BaitShortDesc"), RoleId.Bait, false, true);
        public static RoleInfo sunglasses = new RoleInfo(Lang.Get("SunglassesName"), Color.yellow, Lang.Get("SunglassesIntroDesc"), Lang.Get("SunglassesShortDesc"), RoleId.Sunglasses, false, true);
        public static RoleInfo lover = new RoleInfo(Lang.Get("LoverName"), Lovers.color, Lang.Get("LoverIntroDesc"), Lang.Get("LoverShortDesc"), RoleId.Lover, false, true);
        public static RoleInfo mini = new RoleInfo(Lang.Get("MiniName"), Color.yellow, Lang.Get("MiniIntroDesc"), Lang.Get("MiniShortDesc"), RoleId.Mini, false, true);
        public static RoleInfo vip = new RoleInfo(Lang.Get("VIPName"), Color.yellow, Lang.Get("VIPIntroDesc"), Lang.Get("VIPShortDesc"), RoleId.Vip, false, true);
        public static RoleInfo invert = new RoleInfo(Lang.Get("InvertName"), Color.yellow, Lang.Get("InvertIntroDesc"), Lang.Get("InvertShortDesc"), RoleId.Invert, false, true);
        public static RoleInfo chameleon = new RoleInfo(Lang.Get("ChameleonName"), Color.yellow, Lang.Get("ChameleonIntroDesc"), Lang.Get("ChameleonShortDesc"), RoleId.Chameleon, false, true);
        public static RoleInfo shifter = new RoleInfo(Lang.Get("ShifterName"), Color.yellow, Lang.Get("ShifterIntroDesc"), Lang.Get("ShifterShortDesc"), RoleId.Shifter, false, true);


        public static List<RoleInfo> allRoleInfos = new List<RoleInfo>() {
            impostor,
            godfather,
            mafioso,
            janitor,
            morphling,
            camouflager,
            vampire,
            eraser,
            trickster,
            cleaner,
            warlock,
            bountyHunter,
            witch,
            ninja,
            bomber,
            goodGuesser,
            badGuesser,
            lover,
            jester,
            arsonist,
            jackal,
            sidekick,
            vulture,
            pursuer,
            lawyer,
            thief,
            prosecutor,
            crewmate,
            mayor,
            portalmaker,
            engineer,
            sheriff,
            deputy,
            lighter,
            detective,
            timeMaster,
            medic,
            swapper,
            seer,
            hacker,
            tracker,
            snitch,
            spy,
            securityGuard,
            bait,
            medium,
            trapper,
            bloody,
            antiTeleport,
            tiebreaker,
            sunglasses,
            mini,
            vip,
            invert,
            chameleon,
            shifter
        };

        public static List<RoleInfo> getRoleInfoForPlayer(PlayerControl p, bool showModifier = true) {
            List<RoleInfo> infos = new List<RoleInfo>();
            if (p == null) return infos;

            // Modifier
            if (showModifier) {
                // after dead modifier
                if (!CustomOptionHolder.modifiersAreHidden.getBool() || PlayerControl.LocalPlayer.Data.IsDead || AmongUsClient.Instance.GameState == InnerNet.InnerNetClient.GameStates.Ended)
                {
                    if (Bait.bait.Any(x => x.PlayerId == p.PlayerId)) infos.Add(bait);
                    if (Bloody.bloody.Any(x => x.PlayerId == p.PlayerId)) infos.Add(bloody);
                    if (Vip.vip.Any(x => x.PlayerId == p.PlayerId)) infos.Add(vip);
                }
                if (p == Lovers.lover1 || p == Lovers.lover2) infos.Add(lover);
                if (p == Tiebreaker.tiebreaker) infos.Add(tiebreaker);
                if (AntiTeleport.antiTeleport.Any(x => x.PlayerId == p.PlayerId)) infos.Add(antiTeleport);
                if (Sunglasses.sunglasses.Any(x => x.PlayerId == p.PlayerId)) infos.Add(sunglasses);
                if (p == Mini.mini) infos.Add(mini);
                if (Invert.invert.Any(x => x.PlayerId == p.PlayerId)) infos.Add(invert);
                if (Chameleon.chameleon.Any(x => x.PlayerId == p.PlayerId)) infos.Add(chameleon);
                if (p == Shifter.shifter) infos.Add(shifter);
            }

            int count = infos.Count;  // Save count after modifiers are added so that the role count can be checked

            // Special roles
            if (p == Jester.jester) infos.Add(jester);
            if (p == Mayor.mayor) infos.Add(mayor);
            if (p == Portalmaker.portalmaker) infos.Add(portalmaker);
            if (p == Engineer.engineer) infos.Add(engineer);
            if (p == Sheriff.sheriff || p == Sheriff.formerSheriff) infos.Add(sheriff);
            if (p == Deputy.deputy) infos.Add(deputy);
            if (p == Lighter.lighter) infos.Add(lighter);
            if (p == Godfather.godfather) infos.Add(godfather);
            if (p == Mafioso.mafioso) infos.Add(mafioso);
            if (p == Janitor.janitor) infos.Add(janitor);
            if (p == Morphling.morphling) infos.Add(morphling);
            if (p == Camouflager.camouflager) infos.Add(camouflager);
            if (p == Vampire.vampire) infos.Add(vampire);
            if (p == Eraser.eraser) infos.Add(eraser);
            if (p == Trickster.trickster) infos.Add(trickster);
            if (p == Cleaner.cleaner) infos.Add(cleaner);
            if (p == Warlock.warlock) infos.Add(warlock);
            if (p == Witch.witch) infos.Add(witch);
            if (p == Ninja.ninja) infos.Add(ninja);
            if (p == Bomber.bomber) infos.Add(bomber);
            if (p == Detective.detective) infos.Add(detective);
            if (p == TimeMaster.timeMaster) infos.Add(timeMaster);
            if (p == Medic.medic) infos.Add(medic);
            if (p == Swapper.swapper) infos.Add(swapper);
            if (p == Seer.seer) infos.Add(seer);
            if (p == Hacker.hacker) infos.Add(hacker);
            if (p == Tracker.tracker) infos.Add(tracker);
            if (p == Snitch.snitch) infos.Add(snitch);
            if (p == Jackal.jackal || (Jackal.formerJackals != null && Jackal.formerJackals.Any(x => x.PlayerId == p.PlayerId))) infos.Add(jackal);
            if (p == Sidekick.sidekick) infos.Add(sidekick);
            if (p == Spy.spy) infos.Add(spy);
            if (p == SecurityGuard.securityGuard) infos.Add(securityGuard);
            if (p == Arsonist.arsonist) infos.Add(arsonist);
            if (p == Guesser.niceGuesser) infos.Add(goodGuesser);
            if (p == Guesser.evilGuesser) infos.Add(badGuesser);
            if (p == BountyHunter.bountyHunter) infos.Add(bountyHunter);
            if (p == Vulture.vulture) infos.Add(vulture);
            if (p == Medium.medium) infos.Add(medium);
            if (p == Lawyer.lawyer && !Lawyer.isProsecutor) infos.Add(lawyer);
            if (p == Lawyer.lawyer && Lawyer.isProsecutor) infos.Add(prosecutor);
            if (p == Trapper.trapper) infos.Add(trapper);
            if (p == Pursuer.pursuer) infos.Add(pursuer);
            if (p == Thief.thief) infos.Add(thief);

            // Default roles (just impostor, just crewmate, or hunter / hunted for hide n seek, prop hunt prop ...
            if (infos.Count == count) {
                if (p.Data.Role.IsImpostor)
                    infos.Add(TORMapOptions.gameMode == CustomGamemodes.HideNSeek || TORMapOptions.gameMode == CustomGamemodes.PropHunt ? RoleInfo.hunter : RoleInfo.impostor);
                else
                    infos.Add(TORMapOptions.gameMode == CustomGamemodes.HideNSeek ? RoleInfo.hunted : TORMapOptions.gameMode == CustomGamemodes.PropHunt ? RoleInfo.prop : RoleInfo.crewmate);
            }

            return infos;
        }

        public static String GetRolesString(PlayerControl p, bool useColors, bool showModifier = true, bool suppressGhostInfo = false) {
            string roleName;
            roleName = String.Join(" ", getRoleInfoForPlayer(p, showModifier).Select(x => useColors ? Helpers.cs(x.color, x.name) : x.name).ToArray());
            if (Lawyer.target != null && p.PlayerId == Lawyer.target.PlayerId && CachedPlayer.LocalPlayer.PlayerControl != Lawyer.target) 
                roleName += (useColors ? Helpers.cs(Pursuer.color, " §") : " §");
            if (HandleGuesser.isGuesserGm && HandleGuesser.isGuesser(p.PlayerId)) roleName += " (Guesser)";

            if (!suppressGhostInfo && p != null) {
                if (p == Shifter.shifter && (CachedPlayer.LocalPlayer.PlayerControl == Shifter.shifter || Helpers.shouldShowGhostInfo()) && Shifter.futureShift != null)
                    roleName += Helpers.cs(Color.yellow, " ← " + Shifter.futureShift.Data.PlayerName);
                if (p == Vulture.vulture && (CachedPlayer.LocalPlayer.PlayerControl == Vulture.vulture || Helpers.shouldShowGhostInfo()))
                    roleName = roleName + Helpers.cs(Vulture.color, $" ({Vulture.vultureNumberToWin - Vulture.eatenBodies} left)");
                if (Helpers.shouldShowGhostInfo()) {
                    if (Eraser.futureErased.Contains(p))
                        roleName = Helpers.cs(Color.gray, "(erased) ") + roleName;
                    if (Vampire.vampire != null && !Vampire.vampire.Data.IsDead && Vampire.bitten == p && !p.Data.IsDead)
                        roleName = Helpers.cs(Vampire.color, $"(bitten {(int)HudManagerStartPatch.vampireKillButton.Timer + 1}) ") + roleName;
                    if (Deputy.handcuffedPlayers.Contains(p.PlayerId))
                        roleName = Helpers.cs(Color.gray, "(cuffed) ") + roleName;
                    if (Deputy.handcuffedKnows.ContainsKey(p.PlayerId))  // Active cuff
                        roleName = Helpers.cs(Deputy.color, "(cuffed) ") + roleName;
                    if (p == Warlock.curseVictim)
                        roleName = Helpers.cs(Warlock.color, "(cursed) ") + roleName;
                    if (p == Ninja.ninjaMarked)
                        roleName = Helpers.cs(Ninja.color, "(marked) ") + roleName;
                    if (Pursuer.blankedList.Contains(p) && !p.Data.IsDead)
                        roleName = Helpers.cs(Pursuer.color, "(blanked) ") + roleName;
                    if (Witch.futureSpelled.Contains(p) && !MeetingHud.Instance) // This is already displayed in meetings!
                        roleName = Helpers.cs(Witch.color, "☆ ") + roleName;
                    if (BountyHunter.bounty == p)
                        roleName = Helpers.cs(BountyHunter.color, "(bounty) ") + roleName;
                    if (Arsonist.dousedPlayers.Contains(p))
                        roleName = Helpers.cs(Arsonist.color, "♨ ") + roleName;
                    if (p == Arsonist.arsonist)
                        roleName = roleName + Helpers.cs(Arsonist.color, $" ({CachedPlayer.AllPlayers.Count(x => { return x.PlayerControl != Arsonist.arsonist && !x.Data.IsDead && !x.Data.Disconnected && !Arsonist.dousedPlayers.Any(y => y.PlayerId == x.PlayerId); })} left)");
                    if (p == Jackal.fakeSidekick)
                        roleName = Helpers.cs(Sidekick.color, $" (fake SK)") + roleName;

                    // Death Reason on Ghosts
                    if (p.Data.IsDead) {
                        string deathReasonString = "";
                        var deadPlayer = GameHistory.deadPlayers.FirstOrDefault(x => x.player.PlayerId == p.PlayerId);

                        Color killerColor = new();
                        if (deadPlayer != null && deadPlayer.killerIfExisting != null) {
                            killerColor = RoleInfo.getRoleInfoForPlayer(deadPlayer.killerIfExisting, false).FirstOrDefault().color;
                        }

                        if (deadPlayer != null) {
                            switch (deadPlayer.deathReason) {
                                case DeadPlayer.CustomDeathReason.Disconnect:
                                    deathReasonString = " - disconnected";
                                    break;
                                case DeadPlayer.CustomDeathReason.Exile:
                                    deathReasonString = " - voted out";
                                    break;
                                case DeadPlayer.CustomDeathReason.Kill:
                                    deathReasonString = $" - killed by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.Guess:
                                    if (deadPlayer.killerIfExisting.Data.PlayerName == p.Data.PlayerName)
                                        deathReasonString = $" - failed guess";
                                    else
                                        deathReasonString = $" - guessed by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.Shift:
                                    deathReasonString = $" - {Helpers.cs(Color.yellow, "shifted")} {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.WitchExile:
                                    deathReasonString = $" - {Helpers.cs(Witch.color, "witched")} by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.LoverSuicide:
                                    deathReasonString = $" - {Helpers.cs(Lovers.color, "lover died")}";
                                    break;
                                case DeadPlayer.CustomDeathReason.LawyerSuicide:
                                    deathReasonString = $" - {Helpers.cs(Lawyer.color, "bad Lawyer")}";
                                    break;
                                case DeadPlayer.CustomDeathReason.Bomb:
                                    deathReasonString = $" - bombed by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.Arson:
                                    deathReasonString = $" - burnt by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                            }
                            roleName = roleName + deathReasonString;
                        }
                    }
                }
            }
            return roleName;
        }


        static string ReadmePage = "";
        public static async Task loadReadme() {
            if (ReadmePage == "") {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("https://raw.githubusercontent.com/TheOtherRolesAU/TheOtherRoles/main/README.md");
                response.EnsureSuccessStatusCode();
                string httpres = await response.Content.ReadAsStringAsync();
                ReadmePage = httpres;
            }
        }
        public static string GetRoleDescription(RoleInfo roleInfo) {
            while (ReadmePage == "") {
            }
                
            int index = ReadmePage.IndexOf($"## {roleInfo.name}");
            int endindex = ReadmePage.Substring(index).IndexOf("### Game Options");
            return ReadmePage.Substring(index, endindex);

        }
    }
}
