using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxydustContext : DbContext
{
    public GalaxydustContext()
    {
    }

    public GalaxydustContext(DbContextOptions<GalaxydustContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AuthGroup> AuthGroups { get; set; }

    public virtual DbSet<AuthGroupPermission> AuthGroupPermissions { get; set; }

    public virtual DbSet<AuthPermission> AuthPermissions { get; set; }

    public virtual DbSet<AuthUser> AuthUsers { get; set; }

    public virtual DbSet<AuthUserGroup> AuthUserGroups { get; set; }

    public virtual DbSet<AuthUserUserPermission> AuthUserUserPermissions { get; set; }

    public virtual DbSet<DjangoAdminLog> DjangoAdminLogs { get; set; }

    public virtual DbSet<DjangoContentType> DjangoContentTypes { get; set; }

    public virtual DbSet<DjangoMigration> DjangoMigrations { get; set; }

    public virtual DbSet<DjangoSession> DjangoSessions { get; set; }

    public virtual DbSet<GalaxyDustApiAccount> GalaxyDustApiAccounts { get; set; }

    public virtual DbSet<GalaxyDustApiAccountGroup> GalaxyDustApiAccountGroups { get; set; }

    public virtual DbSet<GalaxyDustApiAccountUserPermission> GalaxyDustApiAccountUserPermissions { get; set; }

    public virtual DbSet<GalaxyDustApiAccountalliance> GalaxyDustApiAccountalliances { get; set; }

    public virtual DbSet<GalaxyDustApiAccountamirecord> GalaxyDustApiAccountamirecords { get; set; }

    public virtual DbSet<GalaxyDustApiAccountamistar> GalaxyDustApiAccountamistars { get; set; }

    public virtual DbSet<GalaxyDustApiAccountastrobot> GalaxyDustApiAccountastrobots { get; set; }

    public virtual DbSet<GalaxyDustApiAccountbadge> GalaxyDustApiAccountbadges { get; set; }

    public virtual DbSet<GalaxyDustApiAccountbag> GalaxyDustApiAccountbags { get; set; }

    public virtual DbSet<GalaxyDustApiAccountbanned> GalaxyDustApiAccountbanneds { get; set; }

    public virtual DbSet<GalaxyDustApiAccountblueprint> GalaxyDustApiAccountblueprints { get; set; }

    public virtual DbSet<GalaxyDustApiAccountcanactiveskill> GalaxyDustApiAccountcanactiveskills { get; set; }

    public virtual DbSet<GalaxyDustApiAccountcurrency> GalaxyDustApiAccountcurrencies { get; set; }

    public virtual DbSet<GalaxyDustApiAccountdefense> GalaxyDustApiAccountdefenses { get; set; }

    public virtual DbSet<GalaxyDustApiAccountessence> GalaxyDustApiAccountessences { get; set; }

    public virtual DbSet<GalaxyDustApiAccountlicense> GalaxyDustApiAccountlicenses { get; set; }

    public virtual DbSet<GalaxyDustApiAccountmaterializer> GalaxyDustApiAccountmaterializers { get; set; }

    public virtual DbSet<GalaxyDustApiAccountpack> GalaxyDustApiAccountpacks { get; set; }

    public virtual DbSet<GalaxyDustApiAccountqmp> GalaxyDustApiAccountqmps { get; set; }

    public virtual DbSet<GalaxyDustApiAccountrepairkit> GalaxyDustApiAccountrepairkits { get; set; }

    public virtual DbSet<GalaxyDustApiAccountship> GalaxyDustApiAccountships { get; set; }

    public virtual DbSet<GalaxyDustApiAccountstructure> GalaxyDustApiAccountstructures { get; set; }

    public virtual DbSet<GalaxyDustApiAccounttechnology> GalaxyDustApiAccounttechnologies { get; set; }

    public virtual DbSet<GalaxyDustApiAccountticket> GalaxyDustApiAccounttickets { get; set; }

    public virtual DbSet<GalaxyDustApiAccounttool> GalaxyDustApiAccounttools { get; set; }

    public virtual DbSet<GalaxyDustApiActivebuyorder> GalaxyDustApiActivebuyorders { get; set; }

    public virtual DbSet<GalaxyDustApiAlliance> GalaxyDustApiAlliances { get; set; }

    public virtual DbSet<GalaxyDustApiAlliancedeposit> GalaxyDustApiAlliancedeposits { get; set; }

    public virtual DbSet<GalaxyDustApiAllianceplanet> GalaxyDustApiAllianceplanets { get; set; }

    public virtual DbSet<GalaxyDustApiAlliancerank> GalaxyDustApiAllianceranks { get; set; }

    public virtual DbSet<GalaxyDustApiAlliancerole> GalaxyDustApiAllianceroles { get; set; }

    public virtual DbSet<GalaxyDustApiAstrobotcategorylevelrequirement> GalaxyDustApiAstrobotcategorylevelrequirements { get; set; }

    public virtual DbSet<GalaxyDustApiAstrobotleveluprequirement> GalaxyDustApiAstrobotleveluprequirements { get; set; }

    public virtual DbSet<GalaxyDustApiAstrobotsize> GalaxyDustApiAstrobotsizes { get; set; }

    public virtual DbSet<GalaxyDustApiAstrobotskilllevelgroup> GalaxyDustApiAstrobotskilllevelgroups { get; set; }

    public virtual DbSet<GalaxyDustApiAstrobotstat> GalaxyDustApiAstrobotstats { get; set; }

    public virtual DbSet<GalaxyDustApiAstrobottype> GalaxyDustApiAstrobottypes { get; set; }

    public virtual DbSet<GalaxyDustApiAstrobottypegroup> GalaxyDustApiAstrobottypegroups { get; set; }

    public virtual DbSet<GalaxyDustApiAttackmultiplier> GalaxyDustApiAttackmultipliers { get; set; }

    public virtual DbSet<GalaxyDustApiAuction> GalaxyDustApiAuctions { get; set; }

    public virtual DbSet<GalaxyDustApiAuctionbid> GalaxyDustApiAuctionbids { get; set; }

    public virtual DbSet<GalaxyDustApiBadgecategorylevelrequirement> GalaxyDustApiBadgecategorylevelrequirements { get; set; }

    public virtual DbSet<GalaxyDustApiBadgeleveluprequirement> GalaxyDustApiBadgeleveluprequirements { get; set; }

    public virtual DbSet<GalaxyDustApiBadgeskilllevelgroup> GalaxyDustApiBadgeskilllevelgroups { get; set; }

    public virtual DbSet<GalaxyDustApiBadgestat> GalaxyDustApiBadgestats { get; set; }

    public virtual DbSet<GalaxyDustApiBadgetype> GalaxyDustApiBadgetypes { get; set; }

    public virtual DbSet<GalaxyDustApiBadgetypegroup> GalaxyDustApiBadgetypegroups { get; set; }

    public virtual DbSet<GalaxyDustApiBagreward> GalaxyDustApiBagrewards { get; set; }

    public virtual DbSet<GalaxyDustApiBagstat> GalaxyDustApiBagstats { get; set; }

    public virtual DbSet<GalaxyDustApiBagtype> GalaxyDustApiBagtypes { get; set; }

    public virtual DbSet<GalaxyDustApiBagtypegroup> GalaxyDustApiBagtypegroups { get; set; }

    public virtual DbSet<GalaxyDustApiBattleskill> GalaxyDustApiBattleskills { get; set; }

    public virtual DbSet<GalaxyDustApiBlockchaininvoice> GalaxyDustApiBlockchaininvoices { get; set; }

    public virtual DbSet<GalaxyDustApiBlueprintrequirement> GalaxyDustApiBlueprintrequirements { get; set; }

    public virtual DbSet<GalaxyDustApiBlueprintstat> GalaxyDustApiBlueprintstats { get; set; }

    public virtual DbSet<GalaxyDustApiBlueprinttype> GalaxyDustApiBlueprinttypes { get; set; }

    public virtual DbSet<GalaxyDustApiBlueprinttypegroup> GalaxyDustApiBlueprinttypegroups { get; set; }

    public virtual DbSet<GalaxyDustApiCan> GalaxyDustApiCans { get; set; }

    public virtual DbSet<GalaxyDustApiCancurrencycapacity> GalaxyDustApiCancurrencycapacities { get; set; }

    public virtual DbSet<GalaxyDustApiCansafedeposit> GalaxyDustApiCansafedeposits { get; set; }

    public virtual DbSet<GalaxyDustApiCollection> GalaxyDustApiCollections { get; set; }

    public virtual DbSet<GalaxyDustApiColortype> GalaxyDustApiColortypes { get; set; }

    public virtual DbSet<GalaxyDustApiCompany> GalaxyDustApiCompanies { get; set; }

    public virtual DbSet<GalaxyDustApiCurrency> GalaxyDustApiCurrencies { get; set; }

    public virtual DbSet<GalaxyDustApiCurrencyastrobotleveluprequirement> GalaxyDustApiCurrencyastrobotleveluprequirements { get; set; }

    public virtual DbSet<GalaxyDustApiCurrencybadgeleveluprequirement> GalaxyDustApiCurrencybadgeleveluprequirements { get; set; }

    public virtual DbSet<GalaxyDustApiCurrencydefenseleveluprequirement> GalaxyDustApiCurrencydefenseleveluprequirements { get; set; }

    public virtual DbSet<GalaxyDustApiCurrencyshipleveluprequirement> GalaxyDustApiCurrencyshipleveluprequirements { get; set; }

    public virtual DbSet<GalaxyDustApiCurrencystructureleveluprequirement> GalaxyDustApiCurrencystructureleveluprequirements { get; set; }

    public virtual DbSet<GalaxyDustApiCurrencytechnologyleveluprequirement> GalaxyDustApiCurrencytechnologyleveluprequirements { get; set; }

    public virtual DbSet<GalaxyDustApiCurrencytoolleveluprequirement> GalaxyDustApiCurrencytoolleveluprequirements { get; set; }

    public virtual DbSet<GalaxyDustApiDefensecategorylevelrequirement> GalaxyDustApiDefensecategorylevelrequirements { get; set; }

    public virtual DbSet<GalaxyDustApiDefenseleveluprequirement> GalaxyDustApiDefenseleveluprequirements { get; set; }

    public virtual DbSet<GalaxyDustApiDefensesize> GalaxyDustApiDefensesizes { get; set; }

    public virtual DbSet<GalaxyDustApiDefenseskilllevelgroup> GalaxyDustApiDefenseskilllevelgroups { get; set; }

    public virtual DbSet<GalaxyDustApiDefensestat> GalaxyDustApiDefensestats { get; set; }

    public virtual DbSet<GalaxyDustApiDefensetype> GalaxyDustApiDefensetypes { get; set; }

    public virtual DbSet<GalaxyDustApiDefensetypegroup> GalaxyDustApiDefensetypegroups { get; set; }

    public virtual DbSet<GalaxyDustApiDestroyed> GalaxyDustApiDestroyeds { get; set; }

    public virtual DbSet<GalaxyDustApiDiscoverlimitedrewardstar> GalaxyDustApiDiscoverlimitedrewardstars { get; set; }

    public virtual DbSet<GalaxyDustApiDiscoverlimitedrewardstat> GalaxyDustApiDiscoverlimitedrewardstats { get; set; }

    public virtual DbSet<GalaxyDustApiDiscoverlimitedrewardstatcurrency> GalaxyDustApiDiscoverlimitedrewardstatcurrencies { get; set; }

    public virtual DbSet<GalaxyDustApiDiscoverlimitedrewardstatitem> GalaxyDustApiDiscoverlimitedrewardstatitems { get; set; }

    public virtual DbSet<GalaxyDustApiDiscoverrewardplanet> GalaxyDustApiDiscoverrewardplanets { get; set; }

    public virtual DbSet<GalaxyDustApiDiscoverrewardstar> GalaxyDustApiDiscoverrewardstars { get; set; }

    public virtual DbSet<GalaxyDustApiDiscoverrewardstat> GalaxyDustApiDiscoverrewardstats { get; set; }

    public virtual DbSet<GalaxyDustApiDiscoverrewardstatcurrency> GalaxyDustApiDiscoverrewardstatcurrencies { get; set; }

    public virtual DbSet<GalaxyDustApiDiscoverrewardstatitem> GalaxyDustApiDiscoverrewardstatitems { get; set; }

    public virtual DbSet<GalaxyDustApiDominationskill> GalaxyDustApiDominationskills { get; set; }

    public virtual DbSet<GalaxyDustApiEmailverification> GalaxyDustApiEmailverifications { get; set; }

    public virtual DbSet<GalaxyDustApiEnemyship> GalaxyDustApiEnemyships { get; set; }

    public virtual DbSet<GalaxyDustApiEnemytype> GalaxyDustApiEnemytypes { get; set; }

    public virtual DbSet<GalaxyDustApiEngine> GalaxyDustApiEngines { get; set; }

    public virtual DbSet<GalaxyDustApiEssencestat> GalaxyDustApiEssencestats { get; set; }

    public virtual DbSet<GalaxyDustApiEssencetype> GalaxyDustApiEssencetypes { get; set; }

    public virtual DbSet<GalaxyDustApiEssencetypegroup> GalaxyDustApiEssencetypegroups { get; set; }

    public virtual DbSet<GalaxyDustApiEvent> GalaxyDustApiEvents { get; set; }

    public virtual DbSet<GalaxyDustApiExpeditionskill> GalaxyDustApiExpeditionskills { get; set; }

    public virtual DbSet<GalaxyDustApiExplorationskill> GalaxyDustApiExplorationskills { get; set; }

    public virtual DbSet<GalaxyDustApiFirstglobaldiscoverrewardstar> GalaxyDustApiFirstglobaldiscoverrewardstars { get; set; }

    public virtual DbSet<GalaxyDustApiFirstglobaldiscoverrewardstat> GalaxyDustApiFirstglobaldiscoverrewardstats { get; set; }

    public virtual DbSet<GalaxyDustApiFirstglobaldiscoverrewardstatcurrency> GalaxyDustApiFirstglobaldiscoverrewardstatcurrencies { get; set; }

    public virtual DbSet<GalaxyDustApiFirstglobaldiscoverrewardstatitem> GalaxyDustApiFirstglobaldiscoverrewardstatitems { get; set; }

    public virtual DbSet<GalaxyDustApiFleetaccountactiveskill> GalaxyDustApiFleetaccountactiveskills { get; set; }

    public virtual DbSet<GalaxyDustApiFleetevent> GalaxyDustApiFleetevents { get; set; }

    public virtual DbSet<GalaxyDustApiFleeteventcurrency> GalaxyDustApiFleeteventcurrencies { get; set; }

    public virtual DbSet<GalaxyDustApiFleeteventitem> GalaxyDustApiFleeteventitems { get; set; }

    public virtual DbSet<GalaxyDustApiFleetgroup> GalaxyDustApiFleetgroups { get; set; }

    public virtual DbSet<GalaxyDustApiFleetgroupnpc> GalaxyDustApiFleetgroupnpcs { get; set; }

    public virtual DbSet<GalaxyDustApiFleetimage> GalaxyDustApiFleetimages { get; set; }

    public virtual DbSet<GalaxyDustApiFlyrequirement> GalaxyDustApiFlyrequirements { get; set; }

    public virtual DbSet<GalaxyDustApiFuselage> GalaxyDustApiFuselages { get; set; }

    public virtual DbSet<GalaxyDustApiFuselagedamagemultiplier> GalaxyDustApiFuselagedamagemultipliers { get; set; }

    public virtual DbSet<GalaxyDustApiGalaxy> GalaxyDustApiGalaxies { get; set; }

    public virtual DbSet<GalaxyDustApiGalaxycluster> GalaxyDustApiGalaxyclusters { get; set; }

    public virtual DbSet<GalaxyDustApiGalaxyclustermaxresource> GalaxyDustApiGalaxyclustermaxresources { get; set; }

    public virtual DbSet<GalaxyDustApiItem> GalaxyDustApiItems { get; set; }

    public virtual DbSet<GalaxyDustApiItemactivationfee> GalaxyDustApiItemactivationfees { get; set; }

    public virtual DbSet<GalaxyDustApiItemactivationfeegroup> GalaxyDustApiItemactivationfeegroups { get; set; }

    public virtual DbSet<GalaxyDustApiItemastrobotleveluprequirement> GalaxyDustApiItemastrobotleveluprequirements { get; set; }

    public virtual DbSet<GalaxyDustApiItembadgeleveluprequirement> GalaxyDustApiItembadgeleveluprequirements { get; set; }

    public virtual DbSet<GalaxyDustApiItemcategory> GalaxyDustApiItemcategories { get; set; }

    public virtual DbSet<GalaxyDustApiItemdefenseleveluprequirement> GalaxyDustApiItemdefenseleveluprequirements { get; set; }

    public virtual DbSet<GalaxyDustApiItemprice> GalaxyDustApiItemprices { get; set; }

    public virtual DbSet<GalaxyDustApiItempricesnft> GalaxyDustApiItempricesnfts { get; set; }

    public virtual DbSet<GalaxyDustApiItemshipleveluprequirement> GalaxyDustApiItemshipleveluprequirements { get; set; }

    public virtual DbSet<GalaxyDustApiItemstructureleveluprequirement> GalaxyDustApiItemstructureleveluprequirements { get; set; }

    public virtual DbSet<GalaxyDustApiItemtechnologyleveluprequirement> GalaxyDustApiItemtechnologyleveluprequirements { get; set; }

    public virtual DbSet<GalaxyDustApiItemtoolleveluprequirement> GalaxyDustApiItemtoolleveluprequirements { get; set; }

    public virtual DbSet<GalaxyDustApiItemtype> GalaxyDustApiItemtypes { get; set; }

    public virtual DbSet<GalaxyDustApiLicensestat> GalaxyDustApiLicensestats { get; set; }

    public virtual DbSet<GalaxyDustApiLicensetype> GalaxyDustApiLicensetypes { get; set; }

    public virtual DbSet<GalaxyDustApiLicensetypegroup> GalaxyDustApiLicensetypegroups { get; set; }

    public virtual DbSet<GalaxyDustApiMarket> GalaxyDustApiMarkets { get; set; }

    public virtual DbSet<GalaxyDustApiMaterializerstat> GalaxyDustApiMaterializerstats { get; set; }

    public virtual DbSet<GalaxyDustApiMaterializertype> GalaxyDustApiMaterializertypes { get; set; }

    public virtual DbSet<GalaxyDustApiMaterializertypegroup> GalaxyDustApiMaterializertypegroups { get; set; }

    public virtual DbSet<GalaxyDustApiMintednft> GalaxyDustApiMintednfts { get; set; }

    public virtual DbSet<GalaxyDustApiNftshop> GalaxyDustApiNftshops { get; set; }

    public virtual DbSet<GalaxyDustApiPackreward> GalaxyDustApiPackrewards { get; set; }

    public virtual DbSet<GalaxyDustApiPackstat> GalaxyDustApiPackstats { get; set; }

    public virtual DbSet<GalaxyDustApiPacktype> GalaxyDustApiPacktypes { get; set; }

    public virtual DbSet<GalaxyDustApiPacktypegroup> GalaxyDustApiPacktypegroups { get; set; }

    public virtual DbSet<GalaxyDustApiPasswordresettoken> GalaxyDustApiPasswordresettokens { get; set; }

    public virtual DbSet<GalaxyDustApiPhantomshop> GalaxyDustApiPhantomshops { get; set; }

    public virtual DbSet<GalaxyDustApiPlanet> GalaxyDustApiPlanets { get; set; }

    public virtual DbSet<GalaxyDustApiPlanetstat> GalaxyDustApiPlanetstats { get; set; }

    public virtual DbSet<GalaxyDustApiQmpstat> GalaxyDustApiQmpstats { get; set; }

    public virtual DbSet<GalaxyDustApiQmptype> GalaxyDustApiQmptypes { get; set; }

    public virtual DbSet<GalaxyDustApiQmptypegroup> GalaxyDustApiQmptypegroups { get; set; }

    public virtual DbSet<GalaxyDustApiRaritytype> GalaxyDustApiRaritytypes { get; set; }

    public virtual DbSet<GalaxyDustApiRepairkitfee> GalaxyDustApiRepairkitfees { get; set; }

    public virtual DbSet<GalaxyDustApiRepairkitstat> GalaxyDustApiRepairkitstats { get; set; }

    public virtual DbSet<GalaxyDustApiRepairkittype> GalaxyDustApiRepairkittypes { get; set; }

    public virtual DbSet<GalaxyDustApiRepairkittypegroup> GalaxyDustApiRepairkittypegroups { get; set; }

    public virtual DbSet<GalaxyDustApiSerie> GalaxyDustApiSeries { get; set; }

    public virtual DbSet<GalaxyDustApiShipcategorylevelrequirement> GalaxyDustApiShipcategorylevelrequirements { get; set; }

    public virtual DbSet<GalaxyDustApiShipfuselagegroup> GalaxyDustApiShipfuselagegroups { get; set; }

    public virtual DbSet<GalaxyDustApiShipleveluprequirement> GalaxyDustApiShipleveluprequirements { get; set; }

    public virtual DbSet<GalaxyDustApiShipsize> GalaxyDustApiShipsizes { get; set; }

    public virtual DbSet<GalaxyDustApiShipskilllevelgroup> GalaxyDustApiShipskilllevelgroups { get; set; }

    public virtual DbSet<GalaxyDustApiShipstat> GalaxyDustApiShipstats { get; set; }

    public virtual DbSet<GalaxyDustApiShiptype> GalaxyDustApiShiptypes { get; set; }

    public virtual DbSet<GalaxyDustApiShiptypegroup> GalaxyDustApiShiptypegroups { get; set; }

    public virtual DbSet<GalaxyDustApiSkillrequirement> GalaxyDustApiSkillrequirements { get; set; }

    public virtual DbSet<GalaxyDustApiSkillstat> GalaxyDustApiSkillstats { get; set; }

    public virtual DbSet<GalaxyDustApiSkilltype> GalaxyDustApiSkilltypes { get; set; }

    public virtual DbSet<GalaxyDustApiStar> GalaxyDustApiStars { get; set; }

    public virtual DbSet<GalaxyDustApiStarcluster> GalaxyDustApiStarclusters { get; set; }

    public virtual DbSet<GalaxyDustApiStarstat> GalaxyDustApiStarstats { get; set; }

    public virtual DbSet<GalaxyDustApiStelarbody> GalaxyDustApiStelarbodies { get; set; }

    public virtual DbSet<GalaxyDustApiStructurecategorylevelrequirement> GalaxyDustApiStructurecategorylevelrequirements { get; set; }

    public virtual DbSet<GalaxyDustApiStructureleveluprequirement> GalaxyDustApiStructureleveluprequirements { get; set; }

    public virtual DbSet<GalaxyDustApiStructureskilllevelgroup> GalaxyDustApiStructureskilllevelgroups { get; set; }

    public virtual DbSet<GalaxyDustApiStructurestat> GalaxyDustApiStructurestats { get; set; }

    public virtual DbSet<GalaxyDustApiStructuretype> GalaxyDustApiStructuretypes { get; set; }

    public virtual DbSet<GalaxyDustApiStructuretypegroup> GalaxyDustApiStructuretypegroups { get; set; }

    public virtual DbSet<GalaxyDustApiTechnologycategorylevelrequirement> GalaxyDustApiTechnologycategorylevelrequirements { get; set; }

    public virtual DbSet<GalaxyDustApiTechnologyleveluprequirement> GalaxyDustApiTechnologyleveluprequirements { get; set; }

    public virtual DbSet<GalaxyDustApiTechnologyskilllevelgroup> GalaxyDustApiTechnologyskilllevelgroups { get; set; }

    public virtual DbSet<GalaxyDustApiTechnologystat> GalaxyDustApiTechnologystats { get; set; }

    public virtual DbSet<GalaxyDustApiTechnologytype> GalaxyDustApiTechnologytypes { get; set; }

    public virtual DbSet<GalaxyDustApiTechnologytypegroup> GalaxyDustApiTechnologytypegroups { get; set; }

    public virtual DbSet<GalaxyDustApiTicketstat> GalaxyDustApiTicketstats { get; set; }

    public virtual DbSet<GalaxyDustApiTickettype> GalaxyDustApiTickettypes { get; set; }

    public virtual DbSet<GalaxyDustApiTickettypegroup> GalaxyDustApiTickettypegroups { get; set; }

    public virtual DbSet<GalaxyDustApiToolcategorylevelrequirement> GalaxyDustApiToolcategorylevelrequirements { get; set; }

    public virtual DbSet<GalaxyDustApiToolleveluprequirement> GalaxyDustApiToolleveluprequirements { get; set; }

    public virtual DbSet<GalaxyDustApiToolskilllevelgroup> GalaxyDustApiToolskilllevelgroups { get; set; }

    public virtual DbSet<GalaxyDustApiToolstat> GalaxyDustApiToolstats { get; set; }

    public virtual DbSet<GalaxyDustApiTooltype> GalaxyDustApiTooltypes { get; set; }

    public virtual DbSet<GalaxyDustApiTooltypegroup> GalaxyDustApiTooltypegroups { get; set; }

    public virtual DbSet<GalaxyDustApiTransportskill> GalaxyDustApiTransportskills { get; set; }

    public virtual DbSet<GalaxyDustApiTravel> GalaxyDustApiTravels { get; set; }

    public virtual DbSet<GalaxyDustApiTraveldatum> GalaxyDustApiTraveldata { get; set; }

    public virtual DbSet<GalaxyDustApiXenogoncurrencyreward> GalaxyDustApiXenogoncurrencyrewards { get; set; }

    public virtual DbSet<GalaxyDustApiXenogonevent> GalaxyDustApiXenogonevents { get; set; }

    public virtual DbSet<GalaxyDustApiXenogonitemreward> GalaxyDustApiXenogonitemrewards { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AuthGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_group_pkey");

            entity.ToTable("auth_group");

            entity.HasIndex(e => e.Name, "auth_group_name_a6ea08ec_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Name, "auth_group_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AuthGroupPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_group_permissions_pkey");

            entity.ToTable("auth_group_permissions");

            entity.HasIndex(e => e.GroupId, "auth_group_permissions_group_id_b120cbf9");

            entity.HasIndex(e => new { e.GroupId, e.PermissionId }, "auth_group_permissions_group_id_permission_id_0cd325b0_uniq").IsUnique();

            entity.HasIndex(e => e.PermissionId, "auth_group_permissions_permission_id_84c5c92e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");

            entity.HasOne(d => d.Group).WithMany(p => p.AuthGroupPermissions)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_group_permissions_group_id_b120cbf9_fk_auth_group_id");

            entity.HasOne(d => d.Permission).WithMany(p => p.AuthGroupPermissions)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_group_permissio_permission_id_84c5c92e_fk_auth_perm");
        });

        modelBuilder.Entity<AuthPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_permission_pkey");

            entity.ToTable("auth_permission");

            entity.HasIndex(e => e.ContentTypeId, "auth_permission_content_type_id_2f476e4b");

            entity.HasIndex(e => new { e.ContentTypeId, e.Codename }, "auth_permission_content_type_id_codename_01ab375a_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codename)
                .HasMaxLength(100)
                .HasColumnName("codename");
            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");

            entity.HasOne(d => d.ContentType).WithMany(p => p.AuthPermissions)
                .HasForeignKey(d => d.ContentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_permission_content_type_id_2f476e4b_fk_django_co");
        });

        modelBuilder.Entity<AuthUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_user_pkey");

            entity.ToTable("auth_user");

            entity.HasIndex(e => e.Username, "auth_user_username_6821ab7c_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Username, "auth_user_username_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateJoined).HasColumnName("date_joined");
            entity.Property(e => e.Email)
                .HasMaxLength(254)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(150)
                .HasColumnName("first_name");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsStaff).HasColumnName("is_staff");
            entity.Property(e => e.IsSuperuser).HasColumnName("is_superuser");
            entity.Property(e => e.LastLogin).HasColumnName("last_login");
            entity.Property(e => e.LastName)
                .HasMaxLength(150)
                .HasColumnName("last_name");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");
        });

        modelBuilder.Entity<AuthUserGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_user_groups_pkey");

            entity.ToTable("auth_user_groups");

            entity.HasIndex(e => e.GroupId, "auth_user_groups_group_id_97559544");

            entity.HasIndex(e => e.UserId, "auth_user_groups_user_id_6a12ed8b");

            entity.HasIndex(e => new { e.UserId, e.GroupId }, "auth_user_groups_user_id_group_id_94350c0c_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Group).WithMany(p => p.AuthUserGroups)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_groups_group_id_97559544_fk_auth_group_id");

            entity.HasOne(d => d.User).WithMany(p => p.AuthUserGroups)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_groups_user_id_6a12ed8b_fk_auth_user_id");
        });

        modelBuilder.Entity<AuthUserUserPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_user_user_permissions_pkey");

            entity.ToTable("auth_user_user_permissions");

            entity.HasIndex(e => e.PermissionId, "auth_user_user_permissions_permission_id_1fbb5f2c");

            entity.HasIndex(e => e.UserId, "auth_user_user_permissions_user_id_a95ead1b");

            entity.HasIndex(e => new { e.UserId, e.PermissionId }, "auth_user_user_permissions_user_id_permission_id_14a6b632_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Permission).WithMany(p => p.AuthUserUserPermissions)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_user_permi_permission_id_1fbb5f2c_fk_auth_perm");

            entity.HasOne(d => d.User).WithMany(p => p.AuthUserUserPermissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_user_permissions_user_id_a95ead1b_fk_auth_user_id");
        });

        modelBuilder.Entity<DjangoAdminLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_admin_log_pkey");

            entity.ToTable("django_admin_log");

            entity.HasIndex(e => e.ContentTypeId, "django_admin_log_content_type_id_c4bce8eb");

            entity.HasIndex(e => e.UserId, "django_admin_log_user_id_c564eba6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionFlag).HasColumnName("action_flag");
            entity.Property(e => e.ActionTime).HasColumnName("action_time");
            entity.Property(e => e.ChangeMessage).HasColumnName("change_message");
            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.ObjectId).HasColumnName("object_id");
            entity.Property(e => e.ObjectRepr)
                .HasMaxLength(200)
                .HasColumnName("object_repr");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.ContentType).WithMany(p => p.DjangoAdminLogs)
                .HasForeignKey(d => d.ContentTypeId)
                .HasConstraintName("django_admin_log_content_type_id_c4bce8eb_fk_django_co");

            entity.HasOne(d => d.User).WithMany(p => p.DjangoAdminLogs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("django_admin_log_user_id_c564eba6_fk_auth_user_id");
        });

        modelBuilder.Entity<DjangoContentType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_content_type_pkey");

            entity.ToTable("django_content_type");

            entity.HasIndex(e => new { e.AppLabel, e.Model }, "django_content_type_app_label_model_76bd3d3b_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppLabel)
                .HasMaxLength(100)
                .HasColumnName("app_label");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .HasColumnName("model");
        });

        modelBuilder.Entity<DjangoMigration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_migrations_pkey");

            entity.ToTable("django_migrations");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.App)
                .HasMaxLength(255)
                .HasColumnName("app");
            entity.Property(e => e.Applied).HasColumnName("applied");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DjangoSession>(entity =>
        {
            entity.HasKey(e => e.SessionKey).HasName("django_session_pkey");

            entity.ToTable("django_session");

            entity.HasIndex(e => e.ExpireDate, "django_session_expire_date_a5c62663");

            entity.HasIndex(e => e.SessionKey, "django_session_session_key_c0390e0f_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.Property(e => e.SessionKey)
                .HasMaxLength(40)
                .HasColumnName("session_key");
            entity.Property(e => e.ExpireDate).HasColumnName("expire_date");
            entity.Property(e => e.SessionData).HasColumnName("session_data");
        });

        modelBuilder.Entity<GalaxyDustApiAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_account_pkey");

            entity.ToTable("galaxy_dust_api_account");

            entity.HasIndex(e => e.Username, "galaxy_dust_api_account_username_65bbb266_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Username, "galaxy_dust_api_account_username_key").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Avatar)
                .HasMaxLength(200)
                .HasColumnName("avatar");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.DateJoined).HasColumnName("date_joined");
            entity.Property(e => e.Email)
                .HasMaxLength(254)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(150)
                .HasColumnName("first_name");
            entity.Property(e => e.Lang)
                .HasMaxLength(255)
                .HasColumnName("lang");
            entity.Property(e => e.LastLogin).HasColumnName("last_login");
            entity.Property(e => e.MetamaskAddress)
                .HasMaxLength(255)
                .HasColumnName("metamask_address");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .HasColumnName("password");
            entity.Property(e => e.RecoveryMode).HasColumnName("recovery_mode");
            entity.Property(e => e.TokenVersion).HasColumnName("token_version");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");
            entity.Property(e => e.Verified).HasColumnName("verified");
        });

        modelBuilder.Entity<GalaxyDustApiAccountGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_account_groups_pkey");

            entity.ToTable("galaxy_dust_api_account_groups");

            entity.HasIndex(e => new { e.AccountId, e.GroupId }, "galaxy_dust_api_account__account_id_group_id_c9e17514_uniq").IsUnique();

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_account_groups_account_id_28b40dbc");

            entity.HasIndex(e => e.GroupId, "galaxy_dust_api_account_groups_group_id_71c91c38");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAccountGroups)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_account_id_28b40dbc_fk_galaxy_du");

            entity.HasOne(d => d.Group).WithMany(p => p.GalaxyDustApiAccountGroups)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_group_id_71c91c38_fk_auth_grou");
        });

        modelBuilder.Entity<GalaxyDustApiAccountUserPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_account_user_permissions_pkey");

            entity.ToTable("galaxy_dust_api_account_user_permissions");

            entity.HasIndex(e => new { e.AccountId, e.PermissionId }, "galaxy_dust_api_account__account_id_permission_id_3691fb41_uniq").IsUnique();

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_account_user_permissions_account_id_67248e3b");

            entity.HasIndex(e => e.PermissionId, "galaxy_dust_api_account_user_permissions_permission_id_7df68fcf");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAccountUserPermissions)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_account_id_67248e3b_fk_galaxy_du");

            entity.HasOne(d => d.Permission).WithMany(p => p.GalaxyDustApiAccountUserPermissions)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_permission_id_7df68fcf_fk_auth_perm");
        });

        modelBuilder.Entity<GalaxyDustApiAccountalliance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_accountalliance_pkey");

            entity.ToTable("galaxy_dust_api_accountalliance");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_accountalliance_account_id_bc2864cd");

            entity.HasIndex(e => e.AllianceId, "galaxy_dust_api_accountalliance_alliance_id_18756edc");

            entity.HasIndex(e => e.RoleId, "galaxy_dust_api_accountalliance_role_id_a1dbdc36");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            entity.Property(e => e.RoleId).HasColumnName("role_id");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAccountalliances)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("galaxy_dust_api_acco_account_id_bc2864cd_fk_galaxy_du");

            entity.HasOne(d => d.Alliance).WithMany(p => p.GalaxyDustApiAccountalliances)
                .HasForeignKey(d => d.AllianceId)
                .HasConstraintName("galaxy_dust_api_acco_alliance_id_18756edc_fk_galaxy_du");

            entity.HasOne(d => d.Role).WithMany(p => p.GalaxyDustApiAccountalliances)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("galaxy_dust_api_acco_role_id_a1dbdc36_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAccountamirecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_accountamirecord_pkey");

            entity.ToTable("galaxy_dust_api_accountamirecord");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_accountamirecord_account_id_29c87969");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.CompletedExpeditions).HasColumnName("completed_expeditions");
            entity.Property(e => e.FirstDiscoveredStartCount).HasColumnName("first_discovered_start_count");
            entity.Property(e => e.TotalExpeditions).HasColumnName("total_expeditions");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAccountamirecords)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("galaxy_dust_api_acco_account_id_29c87969_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAccountamistar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_accountamistar_pkey");

            entity.ToTable("galaxy_dust_api_accountamistar");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_accountamistar_account_id_0fefb5a6");

            entity.HasIndex(e => e.StarId, "galaxy_dust_api_accountamistar_star_id_89aff72d");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.DiscoveredDate).HasColumnName("discovered_date");
            entity.Property(e => e.StarId).HasColumnName("star_id");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAccountamistars)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("galaxy_dust_api_acco_account_id_0fefb5a6_fk_galaxy_du");

            entity.HasOne(d => d.Star).WithMany(p => p.GalaxyDustApiAccountamistars)
                .HasForeignKey(d => d.StarId)
                .HasConstraintName("galaxy_dust_api_acco_star_id_89aff72d_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAccountastrobot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_accountastrobot_pkey");

            entity.ToTable("galaxy_dust_api_accountastrobot");

            entity.HasIndex(e => e.CanId, "galaxy_dust_api_accountastrobot_CAN_id_726128ea");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_accountastrobot_account_id_19d3c970");

            entity.HasIndex(e => e.AstrobotId, "galaxy_dust_api_accountastrobot_astrobot_id_e92e0602");

            entity.HasIndex(e => e.AuctionId, "galaxy_dust_api_accountastrobot_auction_id_e26a2067");

            entity.HasIndex(e => e.FleetGroupId, "galaxy_dust_api_accountastrobot_fleet_group_id_edf4f609");

            entity.HasIndex(e => e.MarketId, "galaxy_dust_api_accountastrobot_market_id_7a8fe969");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AstrobotId).HasColumnName("astrobot_id");
            entity.Property(e => e.AuctionId).HasColumnName("auction_id");
            entity.Property(e => e.CanId).HasColumnName("CAN_id");
            entity.Property(e => e.ContractCollection)
                .HasMaxLength(255)
                .HasColumnName("contract_collection");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Experience).HasColumnName("experience");
            entity.Property(e => e.FleetGroupId).HasColumnName("fleet_group_id");
            entity.Property(e => e.Health).HasColumnName("health");
            entity.Property(e => e.IdNft).HasColumnName("id_nft");
            entity.Property(e => e.IdToken).HasColumnName("id_token");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.MarketId).HasColumnName("market_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.OnAir).HasColumnName("on_air");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAccountastrobots)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_account_id_19d3c970_fk_galaxy_du");

            entity.HasOne(d => d.Astrobot).WithMany(p => p.GalaxyDustApiAccountastrobots)
                .HasForeignKey(d => d.AstrobotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_astrobot_id_e92e0602_fk_galaxy_du");

            entity.HasOne(d => d.Auction).WithMany(p => p.GalaxyDustApiAccountastrobots)
                .HasForeignKey(d => d.AuctionId)
                .HasConstraintName("galaxy_dust_api_acco_auction_id_e26a2067_fk_galaxy_du");

            entity.HasOne(d => d.Can).WithMany(p => p.GalaxyDustApiAccountastrobots)
                .HasForeignKey(d => d.CanId)
                .HasConstraintName("galaxy_dust_api_acco_CAN_id_726128ea_fk_galaxy_du");

            entity.HasOne(d => d.FleetGroup).WithMany(p => p.GalaxyDustApiAccountastrobots)
                .HasForeignKey(d => d.FleetGroupId)
                .HasConstraintName("galaxy_dust_api_acco_fleet_group_id_edf4f609_fk_galaxy_du");

            entity.HasOne(d => d.Market).WithMany(p => p.GalaxyDustApiAccountastrobots)
                .HasForeignKey(d => d.MarketId)
                .HasConstraintName("galaxy_dust_api_acco_market_id_7a8fe969_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAccountbadge>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_accountbadge_pkey");

            entity.ToTable("galaxy_dust_api_accountbadge");

            entity.HasIndex(e => e.CanId, "galaxy_dust_api_accountbadge_CAN_id_5ba27e6e");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_accountbadge_account_id_e5bd587d");

            entity.HasIndex(e => e.AuctionId, "galaxy_dust_api_accountbadge_auction_id_30bf9197");

            entity.HasIndex(e => e.BadgeId, "galaxy_dust_api_accountbadge_badge_id_f4ab8993");

            entity.HasIndex(e => e.MarketId, "galaxy_dust_api_accountbadge_market_id_008e72d5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AuctionId).HasColumnName("auction_id");
            entity.Property(e => e.BadgeId).HasColumnName("badge_id");
            entity.Property(e => e.CanId).HasColumnName("CAN_id");
            entity.Property(e => e.ContractCollection)
                .HasMaxLength(255)
                .HasColumnName("contract_collection");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Experience).HasColumnName("experience");
            entity.Property(e => e.ExpirationTime).HasColumnName("expiration_time");
            entity.Property(e => e.IdNft).HasColumnName("id_nft");
            entity.Property(e => e.IdToken).HasColumnName("id_token");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsFinish).HasColumnName("is_finish");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.MarketId).HasColumnName("market_id");
            entity.Property(e => e.Stack).HasColumnName("stack");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAccountbadges)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_account_id_e5bd587d_fk_galaxy_du");

            entity.HasOne(d => d.Auction).WithMany(p => p.GalaxyDustApiAccountbadges)
                .HasForeignKey(d => d.AuctionId)
                .HasConstraintName("galaxy_dust_api_acco_auction_id_30bf9197_fk_galaxy_du");

            entity.HasOne(d => d.Badge).WithMany(p => p.GalaxyDustApiAccountbadges)
                .HasForeignKey(d => d.BadgeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_badge_id_f4ab8993_fk_galaxy_du");

            entity.HasOne(d => d.Can).WithMany(p => p.GalaxyDustApiAccountbadges)
                .HasForeignKey(d => d.CanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_CAN_id_5ba27e6e_fk_galaxy_du");

            entity.HasOne(d => d.Market).WithMany(p => p.GalaxyDustApiAccountbadges)
                .HasForeignKey(d => d.MarketId)
                .HasConstraintName("galaxy_dust_api_acco_market_id_008e72d5_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAccountbag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_accountbag_pkey");

            entity.ToTable("galaxy_dust_api_accountbag");

            entity.HasIndex(e => e.CanId, "galaxy_dust_api_accountbag_CAN_id_c18d02ed");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_accountbag_account_id_a9d72d32");

            entity.HasIndex(e => e.AuctionId, "galaxy_dust_api_accountbag_auction_id_81102656");

            entity.HasIndex(e => e.BagId, "galaxy_dust_api_accountbag_bag_id_2afb7f72");

            entity.HasIndex(e => e.MarketId, "galaxy_dust_api_accountbag_market_id_fa69a734");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AuctionId).HasColumnName("auction_id");
            entity.Property(e => e.BagId).HasColumnName("bag_id");
            entity.Property(e => e.CanId).HasColumnName("CAN_id");
            entity.Property(e => e.ContractCollection)
                .HasMaxLength(255)
                .HasColumnName("contract_collection");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.IdNft).HasColumnName("id_nft");
            entity.Property(e => e.IdToken).HasColumnName("id_token");
            entity.Property(e => e.MarketId).HasColumnName("market_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAccountbags)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_account_id_a9d72d32_fk_galaxy_du");

            entity.HasOne(d => d.Auction).WithMany(p => p.GalaxyDustApiAccountbags)
                .HasForeignKey(d => d.AuctionId)
                .HasConstraintName("galaxy_dust_api_acco_auction_id_81102656_fk_galaxy_du");

            entity.HasOne(d => d.Bag).WithMany(p => p.GalaxyDustApiAccountbags)
                .HasForeignKey(d => d.BagId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_bag_id_2afb7f72_fk_galaxy_du");

            entity.HasOne(d => d.Can).WithMany(p => p.GalaxyDustApiAccountbags)
                .HasForeignKey(d => d.CanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_CAN_id_c18d02ed_fk_galaxy_du");

            entity.HasOne(d => d.Market).WithMany(p => p.GalaxyDustApiAccountbags)
                .HasForeignKey(d => d.MarketId)
                .HasConstraintName("galaxy_dust_api_acco_market_id_fa69a734_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAccountbanned>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_accountbanned_pkey");

            entity.ToTable("galaxy_dust_api_accountbanned");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_accountbanned_account_id_f2cf3edb");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.DateFrom).HasColumnName("date_from");
            entity.Property(e => e.DateUntil).HasColumnName("date_until");
            entity.Property(e => e.Reason)
                .HasMaxLength(255)
                .HasColumnName("reason");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAccountbanneds)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_account_id_f2cf3edb_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAccountblueprint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_accountblueprint_pkey");

            entity.ToTable("galaxy_dust_api_accountblueprint");

            entity.HasIndex(e => e.CanId, "galaxy_dust_api_accountblueprint_CAN_id_88e97180");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_accountblueprint_account_id_95234882");

            entity.HasIndex(e => e.AuctionId, "galaxy_dust_api_accountblueprint_auction_id_b7b1f0c9");

            entity.HasIndex(e => e.BlueprintId, "galaxy_dust_api_accountblueprint_blueprint_id_7cf3f237");

            entity.HasIndex(e => e.MarketId, "galaxy_dust_api_accountblueprint_market_id_111a38c7");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AuctionId).HasColumnName("auction_id");
            entity.Property(e => e.BlueprintId).HasColumnName("blueprint_id");
            entity.Property(e => e.CanId).HasColumnName("CAN_id");
            entity.Property(e => e.ContractCollection)
                .HasMaxLength(255)
                .HasColumnName("contract_collection");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.IdNft).HasColumnName("id_nft");
            entity.Property(e => e.IdToken).HasColumnName("id_token");
            entity.Property(e => e.MarketId).HasColumnName("market_id");
            entity.Property(e => e.RemainingUses).HasColumnName("remaining_uses");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAccountblueprints)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_account_id_95234882_fk_galaxy_du");

            entity.HasOne(d => d.Auction).WithMany(p => p.GalaxyDustApiAccountblueprints)
                .HasForeignKey(d => d.AuctionId)
                .HasConstraintName("galaxy_dust_api_acco_auction_id_b7b1f0c9_fk_galaxy_du");

            entity.HasOne(d => d.Blueprint).WithMany(p => p.GalaxyDustApiAccountblueprints)
                .HasForeignKey(d => d.BlueprintId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_blueprint_id_7cf3f237_fk_galaxy_du");

            entity.HasOne(d => d.Can).WithMany(p => p.GalaxyDustApiAccountblueprints)
                .HasForeignKey(d => d.CanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_CAN_id_88e97180_fk_galaxy_du");

            entity.HasOne(d => d.Market).WithMany(p => p.GalaxyDustApiAccountblueprints)
                .HasForeignKey(d => d.MarketId)
                .HasConstraintName("galaxy_dust_api_acco_market_id_111a38c7_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAccountcanactiveskill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_accountcanactiveskills_pkey");

            entity.ToTable("galaxy_dust_api_accountcanactiveskills");

            entity.HasIndex(e => e.CanId, "galaxy_dust_api_accountcanactiveskills_can_id_4778ad16");

            entity.HasIndex(e => e.SkillId, "galaxy_dust_api_accountcanactiveskills_skill_id_8241481b");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CanId).HasColumnName("can_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.DisabledUntil).HasColumnName("disabled_until");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.SkillId).HasColumnName("skill_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Can).WithMany(p => p.GalaxyDustApiAccountcanactiveskills)
                .HasForeignKey(d => d.CanId)
                .HasConstraintName("galaxy_dust_api_acco_can_id_4778ad16_fk_galaxy_du");

            entity.HasOne(d => d.Skill).WithMany(p => p.GalaxyDustApiAccountcanactiveskills)
                .HasForeignKey(d => d.SkillId)
                .HasConstraintName("galaxy_dust_api_acco_skill_id_8241481b_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAccountcurrency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_accountcurrency_pkey");

            entity.ToTable("galaxy_dust_api_accountcurrency");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_accountcurrency_account_id_9e9f0dbf");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_accountcurrency_currency_id_1c806482");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.Ammount).HasColumnName("ammount");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAccountcurrencies)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_account_id_9e9f0dbf_fk_galaxy_du");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiAccountcurrencies)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("galaxy_dust_api_acco_currency_id_1c806482_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAccountdefense>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_accountdefense_pkey");

            entity.ToTable("galaxy_dust_api_accountdefense");

            entity.HasIndex(e => e.CanId, "galaxy_dust_api_accountdefense_CAN_id_e369ae07");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_accountdefense_account_id_7b5a652f");

            entity.HasIndex(e => e.AuctionId, "galaxy_dust_api_accountdefense_auction_id_be5bd181");

            entity.HasIndex(e => e.DefenseId, "galaxy_dust_api_accountdefense_defense_id_6c6fc29b");

            entity.HasIndex(e => e.MarketId, "galaxy_dust_api_accountdefense_market_id_e04e662e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AuctionId).HasColumnName("auction_id");
            entity.Property(e => e.CanId).HasColumnName("CAN_id");
            entity.Property(e => e.ContractCollection)
                .HasMaxLength(255)
                .HasColumnName("contract_collection");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.DefenseId).HasColumnName("defense_id");
            entity.Property(e => e.Experience).HasColumnName("experience");
            entity.Property(e => e.Health).HasColumnName("health");
            entity.Property(e => e.IdNft).HasColumnName("id_nft");
            entity.Property(e => e.IdToken).HasColumnName("id_token");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.MarketId).HasColumnName("market_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAccountdefenses)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_account_id_7b5a652f_fk_galaxy_du");

            entity.HasOne(d => d.Auction).WithMany(p => p.GalaxyDustApiAccountdefenses)
                .HasForeignKey(d => d.AuctionId)
                .HasConstraintName("galaxy_dust_api_acco_auction_id_be5bd181_fk_galaxy_du");

            entity.HasOne(d => d.Can).WithMany(p => p.GalaxyDustApiAccountdefenses)
                .HasForeignKey(d => d.CanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_CAN_id_e369ae07_fk_galaxy_du");

            entity.HasOne(d => d.Defense).WithMany(p => p.GalaxyDustApiAccountdefenses)
                .HasForeignKey(d => d.DefenseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_defense_id_6c6fc29b_fk_galaxy_du");

            entity.HasOne(d => d.Market).WithMany(p => p.GalaxyDustApiAccountdefenses)
                .HasForeignKey(d => d.MarketId)
                .HasConstraintName("galaxy_dust_api_acco_market_id_e04e662e_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAccountessence>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_accountessence_pkey");

            entity.ToTable("galaxy_dust_api_accountessence");

            entity.HasIndex(e => e.CanId, "galaxy_dust_api_accountessence_CAN_id_c9338744");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_accountessence_account_id_faa90b49");

            entity.HasIndex(e => e.AuctionId, "galaxy_dust_api_accountessence_auction_id_e9a05aa9");

            entity.HasIndex(e => e.EssenceId, "galaxy_dust_api_accountessence_essence_id_ea727c83");

            entity.HasIndex(e => e.MarketId, "galaxy_dust_api_accountessence_market_id_80ca073f");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AuctionId).HasColumnName("auction_id");
            entity.Property(e => e.CanId).HasColumnName("CAN_id");
            entity.Property(e => e.ContractCollection)
                .HasMaxLength(255)
                .HasColumnName("contract_collection");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.EssenceId).HasColumnName("essence_id");
            entity.Property(e => e.IdNft).HasColumnName("id_nft");
            entity.Property(e => e.IdToken).HasColumnName("id_token");
            entity.Property(e => e.MarketId).HasColumnName("market_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAccountessences)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_account_id_faa90b49_fk_galaxy_du");

            entity.HasOne(d => d.Auction).WithMany(p => p.GalaxyDustApiAccountessences)
                .HasForeignKey(d => d.AuctionId)
                .HasConstraintName("galaxy_dust_api_acco_auction_id_e9a05aa9_fk_galaxy_du");

            entity.HasOne(d => d.Can).WithMany(p => p.GalaxyDustApiAccountessences)
                .HasForeignKey(d => d.CanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_CAN_id_c9338744_fk_galaxy_du");

            entity.HasOne(d => d.Essence).WithMany(p => p.GalaxyDustApiAccountessences)
                .HasForeignKey(d => d.EssenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_essence_id_ea727c83_fk_galaxy_du");

            entity.HasOne(d => d.Market).WithMany(p => p.GalaxyDustApiAccountessences)
                .HasForeignKey(d => d.MarketId)
                .HasConstraintName("galaxy_dust_api_acco_market_id_80ca073f_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAccountlicense>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_accountlicense_pkey");

            entity.ToTable("galaxy_dust_api_accountlicense");

            entity.HasIndex(e => e.CanId, "galaxy_dust_api_accountlicense_CAN_id_99137f79");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_accountlicense_account_id_340f9f7a");

            entity.HasIndex(e => e.AuctionId, "galaxy_dust_api_accountlicense_auction_id_2749d930");

            entity.HasIndex(e => e.LicenseId, "galaxy_dust_api_accountlicense_license_id_cf9a69c2");

            entity.HasIndex(e => e.MarketId, "galaxy_dust_api_accountlicense_market_id_d5a9c251");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AuctionId).HasColumnName("auction_id");
            entity.Property(e => e.CanId).HasColumnName("CAN_id");
            entity.Property(e => e.ContractCollection)
                .HasMaxLength(255)
                .HasColumnName("contract_collection");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.IdNft).HasColumnName("id_nft");
            entity.Property(e => e.IdToken).HasColumnName("id_token");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.LicenseId).HasColumnName("license_id");
            entity.Property(e => e.MarketId).HasColumnName("market_id");
            entity.Property(e => e.StartTime).HasColumnName("start_time");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAccountlicenses)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_account_id_340f9f7a_fk_galaxy_du");

            entity.HasOne(d => d.Auction).WithMany(p => p.GalaxyDustApiAccountlicenses)
                .HasForeignKey(d => d.AuctionId)
                .HasConstraintName("galaxy_dust_api_acco_auction_id_2749d930_fk_galaxy_du");

            entity.HasOne(d => d.Can).WithMany(p => p.GalaxyDustApiAccountlicenses)
                .HasForeignKey(d => d.CanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_CAN_id_99137f79_fk_galaxy_du");

            entity.HasOne(d => d.License).WithMany(p => p.GalaxyDustApiAccountlicenses)
                .HasForeignKey(d => d.LicenseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_license_id_cf9a69c2_fk_galaxy_du");

            entity.HasOne(d => d.Market).WithMany(p => p.GalaxyDustApiAccountlicenses)
                .HasForeignKey(d => d.MarketId)
                .HasConstraintName("galaxy_dust_api_acco_market_id_d5a9c251_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAccountmaterializer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_accountmaterializer_pkey");

            entity.ToTable("galaxy_dust_api_accountmaterializer");

            entity.HasIndex(e => e.CanId, "galaxy_dust_api_accountmaterializer_CAN_id_64d00be4");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_accountmaterializer_account_id_f0b01820");

            entity.HasIndex(e => e.AuctionId, "galaxy_dust_api_accountmaterializer_auction_id_aa7b27e2");

            entity.HasIndex(e => e.MarketId, "galaxy_dust_api_accountmaterializer_market_id_576e739d");

            entity.HasIndex(e => e.MaterializerId, "galaxy_dust_api_accountmaterializer_materializer_id_8ed33716");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AuctionId).HasColumnName("auction_id");
            entity.Property(e => e.CanId).HasColumnName("CAN_id");
            entity.Property(e => e.ContractCollection)
                .HasMaxLength(255)
                .HasColumnName("contract_collection");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.IdNft).HasColumnName("id_nft");
            entity.Property(e => e.IdToken).HasColumnName("id_token");
            entity.Property(e => e.MarketId).HasColumnName("market_id");
            entity.Property(e => e.MaterializerId).HasColumnName("materializer_id");
            entity.Property(e => e.RemainingUses).HasColumnName("remaining_uses");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAccountmaterializers)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_account_id_f0b01820_fk_galaxy_du");

            entity.HasOne(d => d.Auction).WithMany(p => p.GalaxyDustApiAccountmaterializers)
                .HasForeignKey(d => d.AuctionId)
                .HasConstraintName("galaxy_dust_api_acco_auction_id_aa7b27e2_fk_galaxy_du");

            entity.HasOne(d => d.Can).WithMany(p => p.GalaxyDustApiAccountmaterializers)
                .HasForeignKey(d => d.CanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_CAN_id_64d00be4_fk_galaxy_du");

            entity.HasOne(d => d.Market).WithMany(p => p.GalaxyDustApiAccountmaterializers)
                .HasForeignKey(d => d.MarketId)
                .HasConstraintName("galaxy_dust_api_acco_market_id_576e739d_fk_galaxy_du");

            entity.HasOne(d => d.Materializer).WithMany(p => p.GalaxyDustApiAccountmaterializers)
                .HasForeignKey(d => d.MaterializerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_materializer_id_8ed33716_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAccountpack>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_accountpack_pkey");

            entity.ToTable("galaxy_dust_api_accountpack");

            entity.HasIndex(e => e.CanId, "galaxy_dust_api_accountpack_CAN_id_a4790f88");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_accountpack_account_id_f474d243");

            entity.HasIndex(e => e.AuctionId, "galaxy_dust_api_accountpack_auction_id_85d58f7d");

            entity.HasIndex(e => e.MarketId, "galaxy_dust_api_accountpack_market_id_2390ffb7");

            entity.HasIndex(e => e.PackId, "galaxy_dust_api_accountpack_pack_id_84089fc3");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AuctionId).HasColumnName("auction_id");
            entity.Property(e => e.CanId).HasColumnName("CAN_id");
            entity.Property(e => e.ContractCollection)
                .HasMaxLength(255)
                .HasColumnName("contract_collection");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.IdNft).HasColumnName("id_nft");
            entity.Property(e => e.IdToken).HasColumnName("id_token");
            entity.Property(e => e.MarketId).HasColumnName("market_id");
            entity.Property(e => e.PackId).HasColumnName("pack_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAccountpacks)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_account_id_f474d243_fk_galaxy_du");

            entity.HasOne(d => d.Auction).WithMany(p => p.GalaxyDustApiAccountpacks)
                .HasForeignKey(d => d.AuctionId)
                .HasConstraintName("galaxy_dust_api_acco_auction_id_85d58f7d_fk_galaxy_du");

            entity.HasOne(d => d.Can).WithMany(p => p.GalaxyDustApiAccountpacks)
                .HasForeignKey(d => d.CanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_CAN_id_a4790f88_fk_galaxy_du");

            entity.HasOne(d => d.Market).WithMany(p => p.GalaxyDustApiAccountpacks)
                .HasForeignKey(d => d.MarketId)
                .HasConstraintName("galaxy_dust_api_acco_market_id_2390ffb7_fk_galaxy_du");

            entity.HasOne(d => d.Pack).WithMany(p => p.GalaxyDustApiAccountpacks)
                .HasForeignKey(d => d.PackId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_pack_id_84089fc3_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAccountqmp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_accountqmp_pkey");

            entity.ToTable("galaxy_dust_api_accountqmp");

            entity.HasIndex(e => e.CanId, "galaxy_dust_api_accountqmp_CAN_id_27cd70a5");

            entity.HasIndex(e => e.QmpId, "galaxy_dust_api_accountqmp_QMP_id_bf546aca");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_accountqmp_account_id_da156cf8");

            entity.HasIndex(e => e.AuctionId, "galaxy_dust_api_accountqmp_auction_id_55c42724");

            entity.HasIndex(e => e.MarketId, "galaxy_dust_api_accountqmp_market_id_8340c776");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AuctionId).HasColumnName("auction_id");
            entity.Property(e => e.CanId).HasColumnName("CAN_id");
            entity.Property(e => e.ContractCollection)
                .HasMaxLength(255)
                .HasColumnName("contract_collection");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.IdNft).HasColumnName("id_nft");
            entity.Property(e => e.IdToken).HasColumnName("id_token");
            entity.Property(e => e.MarketId).HasColumnName("market_id");
            entity.Property(e => e.OnAir).HasColumnName("on_air");
            entity.Property(e => e.QmpId).HasColumnName("QMP_id");
            entity.Property(e => e.RemainingUses).HasColumnName("remaining_uses");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAccountqmps)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_account_id_da156cf8_fk_galaxy_du");

            entity.HasOne(d => d.Auction).WithMany(p => p.GalaxyDustApiAccountqmps)
                .HasForeignKey(d => d.AuctionId)
                .HasConstraintName("galaxy_dust_api_acco_auction_id_55c42724_fk_galaxy_du");

            entity.HasOne(d => d.Can).WithMany(p => p.GalaxyDustApiAccountqmps)
                .HasForeignKey(d => d.CanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_CAN_id_27cd70a5_fk_galaxy_du");

            entity.HasOne(d => d.Market).WithMany(p => p.GalaxyDustApiAccountqmps)
                .HasForeignKey(d => d.MarketId)
                .HasConstraintName("galaxy_dust_api_acco_market_id_8340c776_fk_galaxy_du");

            entity.HasOne(d => d.Qmp).WithMany(p => p.GalaxyDustApiAccountqmps)
                .HasForeignKey(d => d.QmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_QMP_id_bf546aca_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAccountrepairkit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_accountrepairkit_pkey");

            entity.ToTable("galaxy_dust_api_accountrepairkit");

            entity.HasIndex(e => e.CanId, "galaxy_dust_api_accountrepairkit_CAN_id_ee94ba93");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_accountrepairkit_account_id_d97b0a65");

            entity.HasIndex(e => e.AuctionId, "galaxy_dust_api_accountrepairkit_auction_id_0d50462e");

            entity.HasIndex(e => e.MarketId, "galaxy_dust_api_accountrepairkit_market_id_393a69d7");

            entity.HasIndex(e => e.RepairKitId, "galaxy_dust_api_accountrepairkit_repair_kit_id_95b46dc1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AuctionId).HasColumnName("auction_id");
            entity.Property(e => e.CanId).HasColumnName("CAN_id");
            entity.Property(e => e.ContractCollection)
                .HasMaxLength(255)
                .HasColumnName("contract_collection");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Health).HasColumnName("health");
            entity.Property(e => e.IdNft).HasColumnName("id_nft");
            entity.Property(e => e.IdToken).HasColumnName("id_token");
            entity.Property(e => e.MarketId).HasColumnName("market_id");
            entity.Property(e => e.OnAir).HasColumnName("on_air");
            entity.Property(e => e.RepairKitId).HasColumnName("repair_kit_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAccountrepairkits)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_account_id_d97b0a65_fk_galaxy_du");

            entity.HasOne(d => d.Auction).WithMany(p => p.GalaxyDustApiAccountrepairkits)
                .HasForeignKey(d => d.AuctionId)
                .HasConstraintName("galaxy_dust_api_acco_auction_id_0d50462e_fk_galaxy_du");

            entity.HasOne(d => d.Can).WithMany(p => p.GalaxyDustApiAccountrepairkits)
                .HasForeignKey(d => d.CanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_CAN_id_ee94ba93_fk_galaxy_du");

            entity.HasOne(d => d.Market).WithMany(p => p.GalaxyDustApiAccountrepairkits)
                .HasForeignKey(d => d.MarketId)
                .HasConstraintName("galaxy_dust_api_acco_market_id_393a69d7_fk_galaxy_du");

            entity.HasOne(d => d.RepairKit).WithMany(p => p.GalaxyDustApiAccountrepairkits)
                .HasForeignKey(d => d.RepairKitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_repair_kit_id_95b46dc1_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAccountship>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_accountship_pkey");

            entity.ToTable("galaxy_dust_api_accountship");

            entity.HasIndex(e => e.CanId, "galaxy_dust_api_accountship_CAN_id_cfd68e33");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_accountship_account_id_d16d2cc1");

            entity.HasIndex(e => e.AuctionId, "galaxy_dust_api_accountship_auction_id_65f31513");

            entity.HasIndex(e => e.DestroyedId, "galaxy_dust_api_accountship_destroyed_id_9fd07cbf");

            entity.HasIndex(e => e.FleetGroupId, "galaxy_dust_api_accountship_fleet_group_id_4a8b9bff");

            entity.HasIndex(e => e.MarketId, "galaxy_dust_api_accountship_market_id_244a5bd3");

            entity.HasIndex(e => e.ShipId, "galaxy_dust_api_accountship_ship_id_62e03123");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AuctionId).HasColumnName("auction_id");
            entity.Property(e => e.CanId).HasColumnName("CAN_id");
            entity.Property(e => e.ContractCollection)
                .HasMaxLength(255)
                .HasColumnName("contract_collection");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.DestroyedId).HasColumnName("destroyed_id");
            entity.Property(e => e.Experience).HasColumnName("experience");
            entity.Property(e => e.FleetGroupId).HasColumnName("fleet_group_id");
            entity.Property(e => e.Health).HasColumnName("health");
            entity.Property(e => e.IdNft).HasColumnName("id_nft");
            entity.Property(e => e.IdToken).HasColumnName("id_token");
            entity.Property(e => e.InGame).HasColumnName("in_game");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.MarketId).HasColumnName("market_id");
            entity.Property(e => e.Nickname)
                .HasMaxLength(255)
                .HasColumnName("nickname");
            entity.Property(e => e.OnAir).HasColumnName("on_air");
            entity.Property(e => e.ShipId).HasColumnName("ship_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAccountships)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_account_id_d16d2cc1_fk_galaxy_du");

            entity.HasOne(d => d.Auction).WithMany(p => p.GalaxyDustApiAccountships)
                .HasForeignKey(d => d.AuctionId)
                .HasConstraintName("galaxy_dust_api_acco_auction_id_65f31513_fk_galaxy_du");

            entity.HasOne(d => d.Can).WithMany(p => p.GalaxyDustApiAccountships)
                .HasForeignKey(d => d.CanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_CAN_id_cfd68e33_fk_galaxy_du");

            entity.HasOne(d => d.Destroyed).WithMany(p => p.GalaxyDustApiAccountships)
                .HasForeignKey(d => d.DestroyedId)
                .HasConstraintName("galaxy_dust_api_acco_destroyed_id_9fd07cbf_fk_galaxy_du");

            entity.HasOne(d => d.FleetGroup).WithMany(p => p.GalaxyDustApiAccountships)
                .HasForeignKey(d => d.FleetGroupId)
                .HasConstraintName("galaxy_dust_api_acco_fleet_group_id_4a8b9bff_fk_galaxy_du");

            entity.HasOne(d => d.Market).WithMany(p => p.GalaxyDustApiAccountships)
                .HasForeignKey(d => d.MarketId)
                .HasConstraintName("galaxy_dust_api_acco_market_id_244a5bd3_fk_galaxy_du");

            entity.HasOne(d => d.Ship).WithMany(p => p.GalaxyDustApiAccountships)
                .HasForeignKey(d => d.ShipId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_ship_id_62e03123_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAccountstructure>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_accountstructure_pkey");

            entity.ToTable("galaxy_dust_api_accountstructure");

            entity.HasIndex(e => e.CanId, "galaxy_dust_api_accountstructure_CAN_id_2c71a774");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_accountstructure_account_id_9d1f633d");

            entity.HasIndex(e => e.AuctionId, "galaxy_dust_api_accountstructure_auction_id_4369992c");

            entity.HasIndex(e => e.MarketId, "galaxy_dust_api_accountstructure_market_id_af37d225");

            entity.HasIndex(e => e.StructureId, "galaxy_dust_api_accountstructure_structure_id_7c71398d");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AuctionId).HasColumnName("auction_id");
            entity.Property(e => e.CanId).HasColumnName("CAN_id");
            entity.Property(e => e.ContractCollection)
                .HasMaxLength(255)
                .HasColumnName("contract_collection");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Experience).HasColumnName("experience");
            entity.Property(e => e.IdNft).HasColumnName("id_nft");
            entity.Property(e => e.IdToken).HasColumnName("id_token");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.MarketId).HasColumnName("market_id");
            entity.Property(e => e.StructureId).HasColumnName("structure_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAccountstructures)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_account_id_9d1f633d_fk_galaxy_du");

            entity.HasOne(d => d.Auction).WithMany(p => p.GalaxyDustApiAccountstructures)
                .HasForeignKey(d => d.AuctionId)
                .HasConstraintName("galaxy_dust_api_acco_auction_id_4369992c_fk_galaxy_du");

            entity.HasOne(d => d.Can).WithMany(p => p.GalaxyDustApiAccountstructures)
                .HasForeignKey(d => d.CanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_CAN_id_2c71a774_fk_galaxy_du");

            entity.HasOne(d => d.Market).WithMany(p => p.GalaxyDustApiAccountstructures)
                .HasForeignKey(d => d.MarketId)
                .HasConstraintName("galaxy_dust_api_acco_market_id_af37d225_fk_galaxy_du");

            entity.HasOne(d => d.Structure).WithMany(p => p.GalaxyDustApiAccountstructures)
                .HasForeignKey(d => d.StructureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_structure_id_7c71398d_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAccounttechnology>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_accounttechnology_pkey");

            entity.ToTable("galaxy_dust_api_accounttechnology");

            entity.HasIndex(e => e.CanId, "galaxy_dust_api_accounttechnology_CAN_id_630a02b9");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_accounttechnology_account_id_9464eae3");

            entity.HasIndex(e => e.AuctionId, "galaxy_dust_api_accounttechnology_auction_id_17b6c730");

            entity.HasIndex(e => e.MarketId, "galaxy_dust_api_accounttechnology_market_id_1d7994ff");

            entity.HasIndex(e => e.TechnologyId, "galaxy_dust_api_accounttechnology_technology_id_1db71d0c");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AuctionId).HasColumnName("auction_id");
            entity.Property(e => e.CanId).HasColumnName("CAN_id");
            entity.Property(e => e.ContractCollection)
                .HasMaxLength(255)
                .HasColumnName("contract_collection");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Experience).HasColumnName("experience");
            entity.Property(e => e.IdNft).HasColumnName("id_nft");
            entity.Property(e => e.IdToken).HasColumnName("id_token");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.MarketId).HasColumnName("market_id");
            entity.Property(e => e.TechnologyId).HasColumnName("technology_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAccounttechnologies)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_account_id_9464eae3_fk_galaxy_du");

            entity.HasOne(d => d.Auction).WithMany(p => p.GalaxyDustApiAccounttechnologies)
                .HasForeignKey(d => d.AuctionId)
                .HasConstraintName("galaxy_dust_api_acco_auction_id_17b6c730_fk_galaxy_du");

            entity.HasOne(d => d.Can).WithMany(p => p.GalaxyDustApiAccounttechnologies)
                .HasForeignKey(d => d.CanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_CAN_id_630a02b9_fk_galaxy_du");

            entity.HasOne(d => d.Market).WithMany(p => p.GalaxyDustApiAccounttechnologies)
                .HasForeignKey(d => d.MarketId)
                .HasConstraintName("galaxy_dust_api_acco_market_id_1d7994ff_fk_galaxy_du");

            entity.HasOne(d => d.Technology).WithMany(p => p.GalaxyDustApiAccounttechnologies)
                .HasForeignKey(d => d.TechnologyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_technology_id_1db71d0c_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAccountticket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_accountticket_pkey");

            entity.ToTable("galaxy_dust_api_accountticket");

            entity.HasIndex(e => e.CanId, "galaxy_dust_api_accountticket_CAN_id_66a369a4");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_accountticket_account_id_2659b366");

            entity.HasIndex(e => e.AuctionId, "galaxy_dust_api_accountticket_auction_id_fe465b23");

            entity.HasIndex(e => e.MarketId, "galaxy_dust_api_accountticket_market_id_63fcf4e2");

            entity.HasIndex(e => e.TicketId, "galaxy_dust_api_accountticket_ticket_id_9ec4e00f");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AuctionId).HasColumnName("auction_id");
            entity.Property(e => e.CanId).HasColumnName("CAN_id");
            entity.Property(e => e.ContractCollection)
                .HasMaxLength(255)
                .HasColumnName("contract_collection");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.IdNft).HasColumnName("id_nft");
            entity.Property(e => e.IdToken).HasColumnName("id_token");
            entity.Property(e => e.IsSell).HasColumnName("is_sell");
            entity.Property(e => e.MarketId).HasColumnName("market_id");
            entity.Property(e => e.TicketId).HasColumnName("ticket_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAccounttickets)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_account_id_2659b366_fk_galaxy_du");

            entity.HasOne(d => d.Auction).WithMany(p => p.GalaxyDustApiAccounttickets)
                .HasForeignKey(d => d.AuctionId)
                .HasConstraintName("galaxy_dust_api_acco_auction_id_fe465b23_fk_galaxy_du");

            entity.HasOne(d => d.Can).WithMany(p => p.GalaxyDustApiAccounttickets)
                .HasForeignKey(d => d.CanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_CAN_id_66a369a4_fk_galaxy_du");

            entity.HasOne(d => d.Market).WithMany(p => p.GalaxyDustApiAccounttickets)
                .HasForeignKey(d => d.MarketId)
                .HasConstraintName("galaxy_dust_api_acco_market_id_63fcf4e2_fk_galaxy_du");

            entity.HasOne(d => d.Ticket).WithMany(p => p.GalaxyDustApiAccounttickets)
                .HasForeignKey(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_ticket_id_9ec4e00f_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAccounttool>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_accounttool_pkey");

            entity.ToTable("galaxy_dust_api_accounttool");

            entity.HasIndex(e => e.CanId, "galaxy_dust_api_accounttool_CAN_id_8c4b47be");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_accounttool_account_id_2b1c2021");

            entity.HasIndex(e => e.AuctionId, "galaxy_dust_api_accounttool_auction_id_b9747d36");

            entity.HasIndex(e => e.FleetGroupId, "galaxy_dust_api_accounttool_fleet_group_id_95ba6509");

            entity.HasIndex(e => e.MarketId, "galaxy_dust_api_accounttool_market_id_c260db86");

            entity.HasIndex(e => e.ToolId, "galaxy_dust_api_accounttool_tool_id_f77f850b");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AuctionId).HasColumnName("auction_id");
            entity.Property(e => e.CanId).HasColumnName("CAN_id");
            entity.Property(e => e.ContractCollection)
                .HasMaxLength(255)
                .HasColumnName("contract_collection");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Experience).HasColumnName("experience");
            entity.Property(e => e.FleetGroupId).HasColumnName("fleet_group_id");
            entity.Property(e => e.IdNft).HasColumnName("id_nft");
            entity.Property(e => e.IdToken).HasColumnName("id_token");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.MarketId).HasColumnName("market_id");
            entity.Property(e => e.OnAir).HasColumnName("on_air");
            entity.Property(e => e.ToolId).HasColumnName("tool_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAccounttools)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_account_id_2b1c2021_fk_galaxy_du");

            entity.HasOne(d => d.Auction).WithMany(p => p.GalaxyDustApiAccounttools)
                .HasForeignKey(d => d.AuctionId)
                .HasConstraintName("galaxy_dust_api_acco_auction_id_b9747d36_fk_galaxy_du");

            entity.HasOne(d => d.Can).WithMany(p => p.GalaxyDustApiAccounttools)
                .HasForeignKey(d => d.CanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_CAN_id_8c4b47be_fk_galaxy_du");

            entity.HasOne(d => d.FleetGroup).WithMany(p => p.GalaxyDustApiAccounttools)
                .HasForeignKey(d => d.FleetGroupId)
                .HasConstraintName("galaxy_dust_api_acco_fleet_group_id_95ba6509_fk_galaxy_du");

            entity.HasOne(d => d.Market).WithMany(p => p.GalaxyDustApiAccounttools)
                .HasForeignKey(d => d.MarketId)
                .HasConstraintName("galaxy_dust_api_acco_market_id_c260db86_fk_galaxy_du");

            entity.HasOne(d => d.Tool).WithMany(p => p.GalaxyDustApiAccounttools)
                .HasForeignKey(d => d.ToolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_acco_tool_id_f77f850b_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiActivebuyorder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_activebuyorders_pkey");

            entity.ToTable("galaxy_dust_api_activebuyorders");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_activebuyorders_account_id_89c591b5");

            entity.HasIndex(e => e.MarketId, "galaxy_dust_api_activebuyorders_market_id_4dd1007b");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.MarketId).HasColumnName("market_id");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiActivebuyorders)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("galaxy_dust_api_acti_account_id_89c591b5_fk_galaxy_du");

            entity.HasOne(d => d.Market).WithMany(p => p.GalaxyDustApiActivebuyorders)
                .HasForeignKey(d => d.MarketId)
                .HasConstraintName("galaxy_dust_api_acti_market_id_4dd1007b_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAlliance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_alliance_pkey");

            entity.ToTable("galaxy_dust_api_alliance");

            entity.HasIndex(e => e.AllianceOwnerId, "galaxy_dust_api_alliance_alliance_owner_id_a0d458fb");

            entity.HasIndex(e => e.RankId, "galaxy_dust_api_alliance_rank_id_7700d3b5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AllianceOwnerId).HasColumnName("alliance_owner_id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.RankId).HasColumnName("rank_id");
            entity.Property(e => e.Tag)
                .HasMaxLength(266)
                .HasColumnName("tag");

            entity.HasOne(d => d.AllianceOwner).WithMany(p => p.GalaxyDustApiAlliances)
                .HasForeignKey(d => d.AllianceOwnerId)
                .HasConstraintName("galaxy_dust_api_alli_alliance_owner_id_a0d458fb_fk_galaxy_du");

            entity.HasOne(d => d.Rank).WithMany(p => p.GalaxyDustApiAlliances)
                .HasForeignKey(d => d.RankId)
                .HasConstraintName("galaxy_dust_api_alli_rank_id_7700d3b5_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAlliancedeposit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_alliancedeposit_pkey");

            entity.ToTable("galaxy_dust_api_alliancedeposit");

            entity.HasIndex(e => e.AllianceId, "galaxy_dust_api_alliancedeposit_alliance_id_0706900b");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_alliancedeposit_currency_id_6e1a1ee8");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

            entity.HasOne(d => d.Alliance).WithMany(p => p.GalaxyDustApiAlliancedeposits)
                .HasForeignKey(d => d.AllianceId)
                .HasConstraintName("galaxy_dust_api_alli_alliance_id_0706900b_fk_galaxy_du");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiAlliancedeposits)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("galaxy_dust_api_alli_currency_id_6e1a1ee8_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAllianceplanet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_allianceplanet_pkey");

            entity.ToTable("galaxy_dust_api_allianceplanet");

            entity.HasIndex(e => e.AllianceId, "galaxy_dust_api_allianceplanet_alliance_id_6eeb38f6");

            entity.HasIndex(e => e.PlanetId, "galaxy_dust_api_allianceplanet_planet_id_0a378d75");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            entity.Property(e => e.PlanetId).HasColumnName("planet_id");

            entity.HasOne(d => d.Alliance).WithMany(p => p.GalaxyDustApiAllianceplanets)
                .HasForeignKey(d => d.AllianceId)
                .HasConstraintName("galaxy_dust_api_alli_alliance_id_6eeb38f6_fk_galaxy_du");

            entity.HasOne(d => d.Planet).WithMany(p => p.GalaxyDustApiAllianceplanets)
                .HasForeignKey(d => d.PlanetId)
                .HasConstraintName("galaxy_dust_api_alli_planet_id_0a378d75_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAlliancerank>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_alliancerank_pkey");

            entity.ToTable("galaxy_dust_api_alliancerank");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.MaximumCapacity).HasColumnName("maximum_capacity");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiAlliancerole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_alliancerole_pkey");

            entity.ToTable("galaxy_dust_api_alliancerole");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Permissions)
                .HasColumnType("character varying(255)[]")
                .HasColumnName("permissions");
        });

        modelBuilder.Entity<GalaxyDustApiAstrobotcategorylevelrequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_astrobotcategorylevelrequirement_pkey");

            entity.ToTable("galaxy_dust_api_astrobotcategorylevelrequirement");

            entity.HasIndex(e => e.AstrobotLevelUpRequirementId, "galaxy_dust_api_astrobotca_astrobot_level_up_requirem_e8fc169a");

            entity.HasIndex(e => e.ItemCategoryId, "galaxy_dust_api_astrobotca_item_category_id_3d1184bf");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AstrobotLevelUpRequirementId).HasColumnName("astrobot_level_up_requirement_id");
            entity.Property(e => e.ItemCategoryId).HasColumnName("item_category_id");
            entity.Property(e => e.LevelRequired).HasColumnName("level_required");

            entity.HasOne(d => d.AstrobotLevelUpRequirement).WithMany(p => p.GalaxyDustApiAstrobotcategorylevelrequirements)
                .HasForeignKey(d => d.AstrobotLevelUpRequirementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_astr_astrobot_level_up_re_e8fc169a_fk_galaxy_du");

            entity.HasOne(d => d.ItemCategory).WithMany(p => p.GalaxyDustApiAstrobotcategorylevelrequirements)
                .HasForeignKey(d => d.ItemCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_astr_item_category_id_3d1184bf_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAstrobotleveluprequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_astrobotleveluprequirement_pkey");

            entity.ToTable("galaxy_dust_api_astrobotleveluprequirement");

            entity.HasIndex(e => e.AstrobotId, "galaxy_dust_api_astrobotleveluprequirement_astrobot_id_ef317498");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AstrobotId).HasColumnName("astrobot_id");
            entity.Property(e => e.LevelToEvolve).HasColumnName("level_to_evolve");
            entity.Property(e => e.LevelUpDuration).HasColumnName("level_up_duration");

            entity.HasOne(d => d.Astrobot).WithMany(p => p.GalaxyDustApiAstrobotleveluprequirements)
                .HasForeignKey(d => d.AstrobotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_astr_astrobot_id_ef317498_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAstrobotsize>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_astrobotsize_pkey");

            entity.ToTable("galaxy_dust_api_astrobotsize");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiAstrobotskilllevelgroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_astrobotskilllevelgroup_pkey");

            entity.ToTable("galaxy_dust_api_astrobotskilllevelgroup");

            entity.HasIndex(e => e.AstrobotId, "galaxy_dust_api_astrobotskilllevelgroup_astrobot_id_7ad7cb5f");

            entity.HasIndex(e => e.SkillId, "galaxy_dust_api_astrobotskilllevelgroup_skill_id_33bfbae8");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AstrobotId).HasColumnName("astrobot_id");
            entity.Property(e => e.BlockGroup).HasColumnName("block_group");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.SkillId).HasColumnName("skill_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Astrobot).WithMany(p => p.GalaxyDustApiAstrobotskilllevelgroups)
                .HasForeignKey(d => d.AstrobotId)
                .HasConstraintName("galaxy_dust_api_astr_astrobot_id_7ad7cb5f_fk_galaxy_du");

            entity.HasOne(d => d.Skill).WithMany(p => p.GalaxyDustApiAstrobotskilllevelgroups)
                .HasForeignKey(d => d.SkillId)
                .HasConstraintName("galaxy_dust_api_astr_skill_id_33bfbae8_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAstrobotstat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_astrobotstat_pkey");

            entity.ToTable("galaxy_dust_api_astrobotstat");

            entity.HasIndex(e => e.AstrobotSizeId, "galaxy_dust_api_astrobotstat_astrobot_size_id_0b286785");

            entity.HasIndex(e => e.CollectionId, "galaxy_dust_api_astrobotstat_collection_id_24365e1a");

            entity.HasIndex(e => e.CompanyId, "galaxy_dust_api_astrobotstat_company_id_298cdef5");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_astrobotstat_item_id_key").IsUnique();

            entity.HasIndex(e => e.RarityId, "galaxy_dust_api_astrobotstat_rarity_id_623cb063");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AstrobotSizeId).HasColumnName("astrobot_size_id");
            entity.Property(e => e.CollectionId).HasColumnName("collection_id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Defense).HasColumnName("defense");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.FileDirection)
                .HasMaxLength(200)
                .HasColumnName("file_direction");
            entity.Property(e => e.GravitonAttack).HasColumnName("graviton_attack");
            entity.Property(e => e.IonAttack).HasColumnName("ion_attack");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.KineticAttack).HasColumnName("kinetic_attack");
            entity.Property(e => e.LaserAttack).HasColumnName("laser_attack");
            entity.Property(e => e.MaxLevel).HasColumnName("max_level");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PlasmaAttack).HasColumnName("plasma_attack");
            entity.Property(e => e.PowerScore).HasColumnName("power_score");
            entity.Property(e => e.RarityId).HasColumnName("rarity_id");
            entity.Property(e => e.Shield).HasColumnName("shield");
            entity.Property(e => e.TotalHealth).HasColumnName("total_health");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.AstrobotSize).WithMany(p => p.GalaxyDustApiAstrobotstats)
                .HasForeignKey(d => d.AstrobotSizeId)
                .HasConstraintName("galaxy_dust_api_astr_astrobot_size_id_0b286785_fk_galaxy_du");

            entity.HasOne(d => d.Collection).WithMany(p => p.GalaxyDustApiAstrobotstats)
                .HasForeignKey(d => d.CollectionId)
                .HasConstraintName("galaxy_dust_api_astr_collection_id_24365e1a_fk_galaxy_du");

            entity.HasOne(d => d.Company).WithMany(p => p.GalaxyDustApiAstrobotstats)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("galaxy_dust_api_astr_company_id_298cdef5_fk_galaxy_du");

            entity.HasOne(d => d.Item).WithOne(p => p.GalaxyDustApiAstrobotstat)
                .HasForeignKey<GalaxyDustApiAstrobotstat>(d => d.ItemId)
                .HasConstraintName("galaxy_dust_api_astr_item_id_06827e73_fk_galaxy_du");

            entity.HasOne(d => d.Rarity).WithMany(p => p.GalaxyDustApiAstrobotstats)
                .HasForeignKey(d => d.RarityId)
                .HasConstraintName("galaxy_dust_api_astr_rarity_id_623cb063_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAstrobottype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_astrobottype_pkey");

            entity.ToTable("galaxy_dust_api_astrobottype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiAstrobottypegroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_astrobottypegroup_pkey");

            entity.ToTable("galaxy_dust_api_astrobottypegroup");

            entity.HasIndex(e => e.AstrobotId, "galaxy_dust_api_astrobottypegroup_astrobot_id_8b5b15a8");

            entity.HasIndex(e => e.AstrobotTypeId, "galaxy_dust_api_astrobottypegroup_astrobot_type_id_f5b146f8");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AstrobotId).HasColumnName("astrobot_id");
            entity.Property(e => e.AstrobotTypeId).HasColumnName("astrobot_type_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Astrobot).WithMany(p => p.GalaxyDustApiAstrobottypegroups)
                .HasForeignKey(d => d.AstrobotId)
                .HasConstraintName("galaxy_dust_api_astr_astrobot_id_8b5b15a8_fk_galaxy_du");

            entity.HasOne(d => d.AstrobotType).WithMany(p => p.GalaxyDustApiAstrobottypegroups)
                .HasForeignKey(d => d.AstrobotTypeId)
                .HasConstraintName("galaxy_dust_api_astr_astrobot_type_id_f5b146f8_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAttackmultiplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_attackmultiplier_pkey");

            entity.ToTable("galaxy_dust_api_attackmultiplier");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AttackType)
                .HasMaxLength(255)
                .HasColumnName("attack_type");
            entity.Property(e => e.Multiplier).HasColumnName("multiplier");
        });

        modelBuilder.Entity<GalaxyDustApiAuction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_auctions_pkey");

            entity.ToTable("galaxy_dust_api_auctions");

            entity.HasIndex(e => e.AccountBiggestBidderId, "galaxy_dust_api_auctions_account_biggest_bidder_id_cc943712");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_auctions_account_id_273867e0");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_auctions_currency_id_a31e54f4");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_auctions_item_id_427ff40e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountBiggestBidderId).HasColumnName("account_biggest_bidder_id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AccountItemId).HasColumnName("account_item_id");
            entity.Property(e => e.BiggestBid).HasColumnName("biggest_bid");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.FinalDate).HasColumnName("final_date");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.StartPrice).HasColumnName("start_price");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.AccountBiggestBidder).WithMany(p => p.GalaxyDustApiAuctionAccountBiggestBidders)
                .HasForeignKey(d => d.AccountBiggestBidderId)
                .HasConstraintName("galaxy_dust_api_auct_account_biggest_bidd_cc943712_fk_galaxy_du");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAuctionAccounts)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("galaxy_dust_api_auct_account_id_273867e0_fk_galaxy_du");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiAuctions)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("galaxy_dust_api_auct_currency_id_a31e54f4_fk_galaxy_du");

            entity.HasOne(d => d.Item).WithMany(p => p.GalaxyDustApiAuctions)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("galaxy_dust_api_auct_item_id_427ff40e_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiAuctionbid>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_auctionbid_pkey");

            entity.ToTable("galaxy_dust_api_auctionbid");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_auctionbid_account_id_4852bbec");

            entity.HasIndex(e => e.AuctionId, "galaxy_dust_api_auctionbid_auction_id_88dc5d3f");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.Ammount).HasColumnName("ammount");
            entity.Property(e => e.AuctionId).HasColumnName("auction_id");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiAuctionbids)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("galaxy_dust_api_auct_account_id_4852bbec_fk_galaxy_du");

            entity.HasOne(d => d.Auction).WithMany(p => p.GalaxyDustApiAuctionbids)
                .HasForeignKey(d => d.AuctionId)
                .HasConstraintName("galaxy_dust_api_auct_auction_id_88dc5d3f_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiBadgecategorylevelrequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_badgecategorylevelrequirement_pkey");

            entity.ToTable("galaxy_dust_api_badgecategorylevelrequirement");

            entity.HasIndex(e => e.BadgeLevelUpRequirementId, "galaxy_dust_api_badgecateg_badge_level_up_requirement_751faed1");

            entity.HasIndex(e => e.ItemCategoryId, "galaxy_dust_api_badgecateg_item_category_id_03374fd0");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BadgeLevelUpRequirementId).HasColumnName("badge_level_up_requirement_id");
            entity.Property(e => e.ItemCategoryId).HasColumnName("item_category_id");
            entity.Property(e => e.LevelRequired).HasColumnName("level_required");

            entity.HasOne(d => d.BadgeLevelUpRequirement).WithMany(p => p.GalaxyDustApiBadgecategorylevelrequirements)
                .HasForeignKey(d => d.BadgeLevelUpRequirementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_badg_badge_level_up_requi_751faed1_fk_galaxy_du");

            entity.HasOne(d => d.ItemCategory).WithMany(p => p.GalaxyDustApiBadgecategorylevelrequirements)
                .HasForeignKey(d => d.ItemCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_badg_item_category_id_03374fd0_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiBadgeleveluprequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_badgeleveluprequirement_pkey");

            entity.ToTable("galaxy_dust_api_badgeleveluprequirement");

            entity.HasIndex(e => e.BadgeId, "galaxy_dust_api_badgeleveluprequirement_badge_id_38d82c23");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BadgeId).HasColumnName("badge_id");
            entity.Property(e => e.LevelToEvolve).HasColumnName("level_to_evolve");
            entity.Property(e => e.LevelUpDuration).HasColumnName("level_up_duration");

            entity.HasOne(d => d.Badge).WithMany(p => p.GalaxyDustApiBadgeleveluprequirements)
                .HasForeignKey(d => d.BadgeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_badg_badge_id_38d82c23_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiBadgeskilllevelgroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_badgeskilllevelgroup_pkey");

            entity.ToTable("galaxy_dust_api_badgeskilllevelgroup");

            entity.HasIndex(e => e.BadgeId, "galaxy_dust_api_badgeskilllevelgroup_badge_id_66d35519");

            entity.HasIndex(e => e.SkillId, "galaxy_dust_api_badgeskilllevelgroup_skill_id_a592217a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BadgeId).HasColumnName("badge_id");
            entity.Property(e => e.BlockGroup).HasColumnName("block_group");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.SkillId).HasColumnName("skill_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Badge).WithMany(p => p.GalaxyDustApiBadgeskilllevelgroups)
                .HasForeignKey(d => d.BadgeId)
                .HasConstraintName("galaxy_dust_api_badg_badge_id_66d35519_fk_galaxy_du");

            entity.HasOne(d => d.Skill).WithMany(p => p.GalaxyDustApiBadgeskilllevelgroups)
                .HasForeignKey(d => d.SkillId)
                .HasConstraintName("galaxy_dust_api_badg_skill_id_a592217a_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiBadgestat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_badgestat_pkey");

            entity.ToTable("galaxy_dust_api_badgestat");

            entity.HasIndex(e => e.CollectionId, "galaxy_dust_api_badgestat_collection_id_edb59091");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_badgestat_item_id_key").IsUnique();

            entity.HasIndex(e => e.RarityId, "galaxy_dust_api_badgestat_rarity_id_518ccf7d");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BadgeSlots).HasColumnName("badge_slots");
            entity.Property(e => e.CollectionId).HasColumnName("collection_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.FileDirection)
                .HasMaxLength(200)
                .HasColumnName("file_direction");
            entity.Property(e => e.IsPermanent).HasColumnName("is_permanent");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.MaxLevel).HasColumnName("max_level");
            entity.Property(e => e.MaxStack).HasColumnName("max_stack");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.PowerScore).HasColumnName("power_score");
            entity.Property(e => e.RarityId).HasColumnName("rarity_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Collection).WithMany(p => p.GalaxyDustApiBadgestats)
                .HasForeignKey(d => d.CollectionId)
                .HasConstraintName("galaxy_dust_api_badg_collection_id_edb59091_fk_galaxy_du");

            entity.HasOne(d => d.Item).WithOne(p => p.GalaxyDustApiBadgestat)
                .HasForeignKey<GalaxyDustApiBadgestat>(d => d.ItemId)
                .HasConstraintName("galaxy_dust_api_badg_item_id_0b29137e_fk_galaxy_du");

            entity.HasOne(d => d.Rarity).WithMany(p => p.GalaxyDustApiBadgestats)
                .HasForeignKey(d => d.RarityId)
                .HasConstraintName("galaxy_dust_api_badg_rarity_id_518ccf7d_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiBadgetype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_badgetype_pkey");

            entity.ToTable("galaxy_dust_api_badgetype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiBadgetypegroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_badgetypegroup_pkey");

            entity.ToTable("galaxy_dust_api_badgetypegroup");

            entity.HasIndex(e => e.BadgeId, "galaxy_dust_api_badgetypegroup_badge_id_b76960cb");

            entity.HasIndex(e => e.BadgeTypeId, "galaxy_dust_api_badgetypegroup_badge_type_id_dbc7b883");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BadgeId).HasColumnName("badge_id");
            entity.Property(e => e.BadgeTypeId).HasColumnName("badge_type_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Badge).WithMany(p => p.GalaxyDustApiBadgetypegroups)
                .HasForeignKey(d => d.BadgeId)
                .HasConstraintName("galaxy_dust_api_badg_badge_id_b76960cb_fk_galaxy_du");

            entity.HasOne(d => d.BadgeType).WithMany(p => p.GalaxyDustApiBadgetypegroups)
                .HasForeignKey(d => d.BadgeTypeId)
                .HasConstraintName("galaxy_dust_api_badg_badge_type_id_dbc7b883_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiBagreward>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_bagreward_pkey");

            entity.ToTable("galaxy_dust_api_bagreward");

            entity.HasIndex(e => e.BagId, "galaxy_dust_api_bagreward_bag_id_09c744a6");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_bagreward_currency_id_d46cdd5c");

            entity.HasIndex(e => e.ItemToRewardId, "galaxy_dust_api_bagreward_item_to_reward_id_67438807");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BagId).HasColumnName("bag_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.CurrencyAmount).HasColumnName("currency_amount");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.ItemToRewardId).HasColumnName("item_to_reward_id");
            entity.Property(e => e.Percentage).HasColumnName("percentage");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Bag).WithMany(p => p.GalaxyDustApiBagrewards)
                .HasForeignKey(d => d.BagId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_bagr_bag_id_09c744a6_fk_galaxy_du");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiBagrewards)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("galaxy_dust_api_bagr_currency_id_d46cdd5c_fk_galaxy_du");

            entity.HasOne(d => d.ItemToReward).WithMany(p => p.GalaxyDustApiBagrewards)
                .HasForeignKey(d => d.ItemToRewardId)
                .HasConstraintName("galaxy_dust_api_bagr_item_to_reward_id_67438807_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiBagstat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_bagstat_pkey");

            entity.ToTable("galaxy_dust_api_bagstat");

            entity.HasIndex(e => e.EventId, "galaxy_dust_api_bagstat_event_id_3374b391");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_bagstat_item_id_key").IsUnique();

            entity.HasIndex(e => e.RarityId, "galaxy_dust_api_bagstat_rarity_id_a2de8066");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.FileDirection)
                .HasMaxLength(200)
                .HasColumnName("file_direction");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.RarityId).HasColumnName("rarity_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Event).WithMany(p => p.GalaxyDustApiBagstats)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("galaxy_dust_api_bags_event_id_3374b391_fk_galaxy_du");

            entity.HasOne(d => d.Item).WithOne(p => p.GalaxyDustApiBagstat)
                .HasForeignKey<GalaxyDustApiBagstat>(d => d.ItemId)
                .HasConstraintName("galaxy_dust_api_bags_item_id_1dd03026_fk_galaxy_du");

            entity.HasOne(d => d.Rarity).WithMany(p => p.GalaxyDustApiBagstats)
                .HasForeignKey(d => d.RarityId)
                .HasConstraintName("galaxy_dust_api_bags_rarity_id_a2de8066_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiBagtype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_bagtype_pkey");

            entity.ToTable("galaxy_dust_api_bagtype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiBagtypegroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_bagtypegroup_pkey");

            entity.ToTable("galaxy_dust_api_bagtypegroup");

            entity.HasIndex(e => e.BagId, "galaxy_dust_api_bagtypegroup_bag_id_3def81e6");

            entity.HasIndex(e => e.BagTypeId, "galaxy_dust_api_bagtypegroup_bag_type_id_8ef5a958");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BagId).HasColumnName("bag_id");
            entity.Property(e => e.BagTypeId).HasColumnName("bag_type_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Bag).WithMany(p => p.GalaxyDustApiBagtypegroups)
                .HasForeignKey(d => d.BagId)
                .HasConstraintName("galaxy_dust_api_bagt_bag_id_3def81e6_fk_galaxy_du");

            entity.HasOne(d => d.BagType).WithMany(p => p.GalaxyDustApiBagtypegroups)
                .HasForeignKey(d => d.BagTypeId)
                .HasConstraintName("galaxy_dust_api_bagt_bag_type_id_8ef5a958_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiBattleskill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_battleskill_pkey");

            entity.ToTable("galaxy_dust_api_battleskill");

            entity.HasIndex(e => e.SkillTypeId, "galaxy_dust_api_battleskill_skill_type_id_3610b2c0");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivationProbability).HasColumnName("activation_probability");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.SkillTypeId).HasColumnName("skill_type_id");
            entity.Property(e => e.Stack).HasColumnName("stack");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.SkillType).WithMany(p => p.GalaxyDustApiBattleskills)
                .HasForeignKey(d => d.SkillTypeId)
                .HasConstraintName("galaxy_dust_api_batt_skill_type_id_3610b2c0_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiBlockchaininvoice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_blockchaininvoices_pkey");

            entity.ToTable("galaxy_dust_api_blockchaininvoices");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_blockchaininvoices_account_id_1e6542e8");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_blockchaininvoices_currency_id_a77a64fa");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_blockchaininvoices_item_id_2af77eef");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.CurrencyAmount).HasColumnName("currency_amount");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ItemQuantity).HasColumnName("item_quantity");
            entity.Property(e => e.TransactionHash)
                .HasMaxLength(66)
                .HasColumnName("transaction_hash");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiBlockchaininvoices)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("galaxy_dust_api_bloc_account_id_1e6542e8_fk_galaxy_du");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiBlockchaininvoices)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("galaxy_dust_api_bloc_currency_id_a77a64fa_fk_galaxy_du");

            entity.HasOne(d => d.Item).WithMany(p => p.GalaxyDustApiBlockchaininvoices)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("galaxy_dust_api_bloc_item_id_2af77eef_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiBlueprintrequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_blueprintrequirements_pkey");

            entity.ToTable("galaxy_dust_api_blueprintrequirements");

            entity.HasIndex(e => e.BlueprintId, "galaxy_dust_api_blueprintrequirements_blueprint_id_9fc4adf6");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_blueprintrequirements_currency_id_39bc5035");

            entity.HasIndex(e => e.ItemCategoryId, "galaxy_dust_api_blueprintrequirements_item_category_id_8e039c3d");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_blueprintrequirements_item_id_6ec58993");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BlueprintId).HasColumnName("blueprint_id");
            entity.Property(e => e.CurrencyAmount).HasColumnName("currency_amount");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.IsBurnable).HasColumnName("is_burnable");
            entity.Property(e => e.ItemCategoryId).HasColumnName("item_category_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ItemLevel).HasColumnName("item_level");
            entity.Property(e => e.NumberOfItems).HasColumnName("number_of_items");

            entity.HasOne(d => d.Blueprint).WithMany(p => p.GalaxyDustApiBlueprintrequirements)
                .HasForeignKey(d => d.BlueprintId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_blue_blueprint_id_9fc4adf6_fk_galaxy_du");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiBlueprintrequirements)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("galaxy_dust_api_blue_currency_id_39bc5035_fk_galaxy_du");

            entity.HasOne(d => d.ItemCategory).WithMany(p => p.GalaxyDustApiBlueprintrequirements)
                .HasForeignKey(d => d.ItemCategoryId)
                .HasConstraintName("galaxy_dust_api_blue_item_category_id_8e039c3d_fk_galaxy_du");

            entity.HasOne(d => d.Item).WithMany(p => p.GalaxyDustApiBlueprintrequirements)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("galaxy_dust_api_blue_item_id_6ec58993_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiBlueprintstat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_blueprintstat_pkey");

            entity.ToTable("galaxy_dust_api_blueprintstat");

            entity.HasIndex(e => e.BlueprintResultItemId, "galaxy_dust_api_blueprintstat_blueprint_result_item_id_ce619fde");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_blueprintstat_item_id_key").IsUnique();

            entity.HasIndex(e => e.ItemTypeId, "galaxy_dust_api_blueprintstat_item_type_id_713c52eb");

            entity.HasIndex(e => e.RarityId, "galaxy_dust_api_blueprintstat_rarity_id_a088a166");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BlueprintResultItemId).HasColumnName("blueprint_result_item_id");
            entity.Property(e => e.CreateDuration).HasColumnName("create_duration");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.FileDirection)
                .HasMaxLength(200)
                .HasColumnName("file_direction");
            entity.Property(e => e.IsRandom).HasColumnName("is_random");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ItemTypeId).HasColumnName("item_type_id");
            entity.Property(e => e.MaxUses).HasColumnName("max_uses");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.Percentage).HasColumnName("percentage");
            entity.Property(e => e.RarityId).HasColumnName("rarity_id");
            entity.Property(e => e.RarityNames)
                .HasColumnType("character varying(500)[]")
                .HasColumnName("rarity_names");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.BlueprintResultItem).WithMany(p => p.GalaxyDustApiBlueprintstatBlueprintResultItems)
                .HasForeignKey(d => d.BlueprintResultItemId)
                .HasConstraintName("galaxy_dust_api_blue_blueprint_result_ite_ce619fde_fk_galaxy_du");

            entity.HasOne(d => d.Item).WithOne(p => p.GalaxyDustApiBlueprintstatItem)
                .HasForeignKey<GalaxyDustApiBlueprintstat>(d => d.ItemId)
                .HasConstraintName("galaxy_dust_api_blue_item_id_0d654ca0_fk_galaxy_du");

            entity.HasOne(d => d.ItemType).WithMany(p => p.GalaxyDustApiBlueprintstats)
                .HasForeignKey(d => d.ItemTypeId)
                .HasConstraintName("galaxy_dust_api_blue_item_type_id_713c52eb_fk_galaxy_du");

            entity.HasOne(d => d.Rarity).WithMany(p => p.GalaxyDustApiBlueprintstats)
                .HasForeignKey(d => d.RarityId)
                .HasConstraintName("galaxy_dust_api_blue_rarity_id_a088a166_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiBlueprinttype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_blueprinttype_pkey");

            entity.ToTable("galaxy_dust_api_blueprinttype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiBlueprinttypegroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_blueprinttypegroup_pkey");

            entity.ToTable("galaxy_dust_api_blueprinttypegroup");

            entity.HasIndex(e => e.BlueprintId, "galaxy_dust_api_blueprinttypegroup_blueprint_id_b1541a0a");

            entity.HasIndex(e => e.BlueprintTypeId, "galaxy_dust_api_blueprinttypegroup_blueprint_type_id_01b4f077");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BlueprintId).HasColumnName("blueprint_id");
            entity.Property(e => e.BlueprintTypeId).HasColumnName("blueprint_type_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Blueprint).WithMany(p => p.GalaxyDustApiBlueprinttypegroups)
                .HasForeignKey(d => d.BlueprintId)
                .HasConstraintName("galaxy_dust_api_blue_blueprint_id_b1541a0a_fk_galaxy_du");

            entity.HasOne(d => d.BlueprintType).WithMany(p => p.GalaxyDustApiBlueprinttypegroups)
                .HasForeignKey(d => d.BlueprintTypeId)
                .HasConstraintName("galaxy_dust_api_blue_blueprint_type_id_01b4f077_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiCan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_can_pkey");

            entity.ToTable("galaxy_dust_api_can");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_can_account_id_0784c242");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.FleetSpace).HasColumnName("fleet_space");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiCans)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("galaxy_dust_api_can_account_id_0784c242_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiCancurrencycapacity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_cancurrencycapacity_pkey");

            entity.ToTable("galaxy_dust_api_cancurrencycapacity");

            entity.HasIndex(e => e.CanId, "galaxy_dust_api_cancurrencycapacity_can_id_18d5fbd8");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_cancurrencycapacity_currency_id_9f154480");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CanId).HasColumnName("can_id");
            entity.Property(e => e.Capacity).HasColumnName("capacity");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

            entity.HasOne(d => d.Can).WithMany(p => p.GalaxyDustApiCancurrencycapacities)
                .HasForeignKey(d => d.CanId)
                .HasConstraintName("galaxy_dust_api_canc_can_id_18d5fbd8_fk_galaxy_du");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiCancurrencycapacities)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("galaxy_dust_api_canc_currency_id_9f154480_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiCansafedeposit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_cansafedeposit_pkey");

            entity.ToTable("galaxy_dust_api_cansafedeposit");

            entity.HasIndex(e => e.CanId, "galaxy_dust_api_cansafedeposit_can_id_ecbcee08");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_cansafedeposit_currency_id_833fe849");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CanId).HasColumnName("can_id");
            entity.Property(e => e.CurrencyAmmount).HasColumnName("currency_ammount");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

            entity.HasOne(d => d.Can).WithMany(p => p.GalaxyDustApiCansafedeposits)
                .HasForeignKey(d => d.CanId)
                .HasConstraintName("galaxy_dust_api_cans_can_id_ecbcee08_fk_galaxy_du");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiCansafedeposits)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("galaxy_dust_api_cans_currency_id_833fe849_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiCollection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_collection_pkey");

            entity.ToTable("galaxy_dust_api_collection");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiColortype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_colortype_pkey");

            entity.ToTable("galaxy_dust_api_colortype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ColorHex)
                .HasMaxLength(255)
                .HasColumnName("color_hex");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiCompany>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_company_pkey");

            entity.ToTable("galaxy_dust_api_company");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiCurrency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_currency_pkey");

            entity.ToTable("galaxy_dust_api_currency");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Icon)
                .HasMaxLength(500)
                .HasColumnName("icon");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiCurrencyastrobotleveluprequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_currencyastrobotleveluprequirement_pkey");

            entity.ToTable("galaxy_dust_api_currencyastrobotleveluprequirement");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_currencyas_currency_id_e346349d");

            entity.HasIndex(e => e.RequirementId, "galaxy_dust_api_currencyas_requirement_id_bc904eb7");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.IsBurnable).HasColumnName("is_burnable");
            entity.Property(e => e.RequirementId).HasColumnName("requirement_id");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiCurrencyastrobotleveluprequirements)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_curr_currency_id_e346349d_fk_galaxy_du");

            entity.HasOne(d => d.Requirement).WithMany(p => p.GalaxyDustApiCurrencyastrobotleveluprequirements)
                .HasForeignKey(d => d.RequirementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_curr_requirement_id_bc904eb7_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiCurrencybadgeleveluprequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_currencybadgeleveluprequirement_pkey");

            entity.ToTable("galaxy_dust_api_currencybadgeleveluprequirement");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_currencyba_currency_id_d19f9eab");

            entity.HasIndex(e => e.RequirementId, "galaxy_dust_api_currencyba_requirement_id_c556ac44");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.IsBurnable).HasColumnName("is_burnable");
            entity.Property(e => e.RequirementId).HasColumnName("requirement_id");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiCurrencybadgeleveluprequirements)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_curr_currency_id_d19f9eab_fk_galaxy_du");

            entity.HasOne(d => d.Requirement).WithMany(p => p.GalaxyDustApiCurrencybadgeleveluprequirements)
                .HasForeignKey(d => d.RequirementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_curr_requirement_id_c556ac44_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiCurrencydefenseleveluprequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_currencydefenseleveluprequirement_pkey");

            entity.ToTable("galaxy_dust_api_currencydefenseleveluprequirement");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_currencyde_currency_id_a7b1b278");

            entity.HasIndex(e => e.RequirementId, "galaxy_dust_api_currencyde_requirement_id_37f54696");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.IsBurnable).HasColumnName("is_burnable");
            entity.Property(e => e.RequirementId).HasColumnName("requirement_id");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiCurrencydefenseleveluprequirements)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_curr_currency_id_a7b1b278_fk_galaxy_du");

            entity.HasOne(d => d.Requirement).WithMany(p => p.GalaxyDustApiCurrencydefenseleveluprequirements)
                .HasForeignKey(d => d.RequirementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_curr_requirement_id_37f54696_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiCurrencyshipleveluprequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_currencyshipleveluprequirement_pkey");

            entity.ToTable("galaxy_dust_api_currencyshipleveluprequirement");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_currencysh_currency_id_48a911c3");

            entity.HasIndex(e => e.RequirementId, "galaxy_dust_api_currencysh_requirement_id_e7a87660");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.IsBurnable).HasColumnName("is_burnable");
            entity.Property(e => e.RequirementId).HasColumnName("requirement_id");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiCurrencyshipleveluprequirements)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_curr_currency_id_48a911c3_fk_galaxy_du");

            entity.HasOne(d => d.Requirement).WithMany(p => p.GalaxyDustApiCurrencyshipleveluprequirements)
                .HasForeignKey(d => d.RequirementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_curr_requirement_id_e7a87660_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiCurrencystructureleveluprequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_currencystructureleveluprequirement_pkey");

            entity.ToTable("galaxy_dust_api_currencystructureleveluprequirement");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_currencyst_currency_id_1c6a2603");

            entity.HasIndex(e => e.RequirementId, "galaxy_dust_api_currencyst_requirement_id_4ae148a9");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.IsBurnable).HasColumnName("is_burnable");
            entity.Property(e => e.RequirementId).HasColumnName("requirement_id");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiCurrencystructureleveluprequirements)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_curr_currency_id_1c6a2603_fk_galaxy_du");

            entity.HasOne(d => d.Requirement).WithMany(p => p.GalaxyDustApiCurrencystructureleveluprequirements)
                .HasForeignKey(d => d.RequirementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_curr_requirement_id_4ae148a9_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiCurrencytechnologyleveluprequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_currencytechnologyleveluprequirement_pkey");

            entity.ToTable("galaxy_dust_api_currencytechnologyleveluprequirement");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_currencyte_currency_id_f24a77f3");

            entity.HasIndex(e => e.RequirementId, "galaxy_dust_api_currencyte_requirement_id_697fee6e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.IsBurnable).HasColumnName("is_burnable");
            entity.Property(e => e.RequirementId).HasColumnName("requirement_id");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiCurrencytechnologyleveluprequirements)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_curr_currency_id_f24a77f3_fk_galaxy_du");

            entity.HasOne(d => d.Requirement).WithMany(p => p.GalaxyDustApiCurrencytechnologyleveluprequirements)
                .HasForeignKey(d => d.RequirementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_curr_requirement_id_697fee6e_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiCurrencytoolleveluprequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_currencytoolleveluprequirement_pkey");

            entity.ToTable("galaxy_dust_api_currencytoolleveluprequirement");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_currencyto_currency_id_7b1910ab");

            entity.HasIndex(e => e.RequirementId, "galaxy_dust_api_currencyto_requirement_id_a52804b8");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.IsBurnable).HasColumnName("is_burnable");
            entity.Property(e => e.RequirementId).HasColumnName("requirement_id");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiCurrencytoolleveluprequirements)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_curr_currency_id_7b1910ab_fk_galaxy_du");

            entity.HasOne(d => d.Requirement).WithMany(p => p.GalaxyDustApiCurrencytoolleveluprequirements)
                .HasForeignKey(d => d.RequirementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_curr_requirement_id_a52804b8_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiDefensecategorylevelrequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_defensecategorylevelrequirement_pkey");

            entity.ToTable("galaxy_dust_api_defensecategorylevelrequirement");

            entity.HasIndex(e => e.DefenseLevelUpRequirementId, "galaxy_dust_api_defensecat_defense_level_up_requireme_e788a2e7");

            entity.HasIndex(e => e.ItemCategoryId, "galaxy_dust_api_defensecat_item_category_id_081ce3df");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DefenseLevelUpRequirementId).HasColumnName("defense_level_up_requirement_id");
            entity.Property(e => e.ItemCategoryId).HasColumnName("item_category_id");
            entity.Property(e => e.LevelRequired).HasColumnName("level_required");

            entity.HasOne(d => d.DefenseLevelUpRequirement).WithMany(p => p.GalaxyDustApiDefensecategorylevelrequirements)
                .HasForeignKey(d => d.DefenseLevelUpRequirementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_defe_defense_level_up_req_e788a2e7_fk_galaxy_du");

            entity.HasOne(d => d.ItemCategory).WithMany(p => p.GalaxyDustApiDefensecategorylevelrequirements)
                .HasForeignKey(d => d.ItemCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_defe_item_category_id_081ce3df_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiDefenseleveluprequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_defenseleveluprequirement_pkey");

            entity.ToTable("galaxy_dust_api_defenseleveluprequirement");

            entity.HasIndex(e => e.DefenseId, "galaxy_dust_api_defenseleveluprequirement_defense_id_0364a8d1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DefenseId).HasColumnName("defense_id");
            entity.Property(e => e.LevelToEvolve).HasColumnName("level_to_evolve");
            entity.Property(e => e.LevelUpDuration).HasColumnName("level_up_duration");

            entity.HasOne(d => d.Defense).WithMany(p => p.GalaxyDustApiDefenseleveluprequirements)
                .HasForeignKey(d => d.DefenseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_defe_defense_id_0364a8d1_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiDefensesize>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_defensesize_pkey");

            entity.ToTable("galaxy_dust_api_defensesize");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiDefenseskilllevelgroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_defenseskilllevelgroup_pkey");

            entity.ToTable("galaxy_dust_api_defenseskilllevelgroup");

            entity.HasIndex(e => e.DefenseId, "galaxy_dust_api_defenseskilllevelgroup_defense_id_c12a7b74");

            entity.HasIndex(e => e.SkillId, "galaxy_dust_api_defenseskilllevelgroup_skill_id_44a131f8");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BlockGroup).HasColumnName("block_group");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.DefenseId).HasColumnName("defense_id");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.SkillId).HasColumnName("skill_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Defense).WithMany(p => p.GalaxyDustApiDefenseskilllevelgroups)
                .HasForeignKey(d => d.DefenseId)
                .HasConstraintName("galaxy_dust_api_defe_defense_id_c12a7b74_fk_galaxy_du");

            entity.HasOne(d => d.Skill).WithMany(p => p.GalaxyDustApiDefenseskilllevelgroups)
                .HasForeignKey(d => d.SkillId)
                .HasConstraintName("galaxy_dust_api_defe_skill_id_44a131f8_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiDefensestat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_defensestat_pkey");

            entity.ToTable("galaxy_dust_api_defensestat");

            entity.HasIndex(e => e.DefenseSizeId, "galaxy_dust_api_defensestat_defense_size_id_39921b2a");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_defensestat_item_id_key").IsUnique();

            entity.HasIndex(e => e.RarityId, "galaxy_dust_api_defensestat_rarity_id_71aa884f");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Defense).HasColumnName("defense");
            entity.Property(e => e.DefenseSizeId).HasColumnName("defense_size_id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.FileDirection)
                .HasMaxLength(200)
                .HasColumnName("file_direction");
            entity.Property(e => e.GravitonAttack).HasColumnName("graviton_attack");
            entity.Property(e => e.IonAttack).HasColumnName("ion_attack");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.KineticAttack).HasColumnName("kinetic_attack");
            entity.Property(e => e.LaserAttack).HasColumnName("laser_attack");
            entity.Property(e => e.MaxLevel).HasColumnName("max_level");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PlasmaAttack).HasColumnName("plasma_attack");
            entity.Property(e => e.PowerScore).HasColumnName("power_score");
            entity.Property(e => e.RarityId).HasColumnName("rarity_id");
            entity.Property(e => e.Shield).HasColumnName("shield");
            entity.Property(e => e.TotalHealth).HasColumnName("total_health");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.DefenseSize).WithMany(p => p.GalaxyDustApiDefensestats)
                .HasForeignKey(d => d.DefenseSizeId)
                .HasConstraintName("galaxy_dust_api_defe_defense_size_id_39921b2a_fk_galaxy_du");

            entity.HasOne(d => d.Item).WithOne(p => p.GalaxyDustApiDefensestat)
                .HasForeignKey<GalaxyDustApiDefensestat>(d => d.ItemId)
                .HasConstraintName("galaxy_dust_api_defe_item_id_da2dc544_fk_galaxy_du");

            entity.HasOne(d => d.Rarity).WithMany(p => p.GalaxyDustApiDefensestats)
                .HasForeignKey(d => d.RarityId)
                .HasConstraintName("galaxy_dust_api_defe_rarity_id_71aa884f_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiDefensetype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_defensetype_pkey");

            entity.ToTable("galaxy_dust_api_defensetype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiDefensetypegroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_defensetypegroup_pkey");

            entity.ToTable("galaxy_dust_api_defensetypegroup");

            entity.HasIndex(e => e.DefenseId, "galaxy_dust_api_defensetypegroup_defense_id_989b38e4");

            entity.HasIndex(e => e.DefenseTypeId, "galaxy_dust_api_defensetypegroup_defense_type_id_c4d3123c");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.DefenseId).HasColumnName("defense_id");
            entity.Property(e => e.DefenseTypeId).HasColumnName("defense_type_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Defense).WithMany(p => p.GalaxyDustApiDefensetypegroups)
                .HasForeignKey(d => d.DefenseId)
                .HasConstraintName("galaxy_dust_api_defe_defense_id_989b38e4_fk_galaxy_du");

            entity.HasOne(d => d.DefenseType).WithMany(p => p.GalaxyDustApiDefensetypegroups)
                .HasForeignKey(d => d.DefenseTypeId)
                .HasConstraintName("galaxy_dust_api_defe_defense_type_id_c4d3123c_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiDestroyed>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_destroyed_pkey");

            entity.ToTable("galaxy_dust_api_destroyed");

            entity.HasIndex(e => e.ShipId, "galaxy_dust_api_destroyed_ship_id_eb8db2eb");

            entity.HasIndex(e => e.StelarBodyId, "galaxy_dust_api_destroyed_stelar_body_id_60b136bf");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.ShipId).HasColumnName("ship_id");
            entity.Property(e => e.StelarBodyId).HasColumnName("stelar_body_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Ship).WithMany(p => p.GalaxyDustApiDestroyeds)
                .HasForeignKey(d => d.ShipId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_dest_ship_id_eb8db2eb_fk_galaxy_du");

            entity.HasOne(d => d.StelarBody).WithMany(p => p.GalaxyDustApiDestroyeds)
                .HasForeignKey(d => d.StelarBodyId)
                .HasConstraintName("galaxy_dust_api_dest_stelar_body_id_60b136bf_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiDiscoverlimitedrewardstar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_discoverlimitedrewardstar_pkey");

            entity.ToTable("galaxy_dust_api_discoverlimitedrewardstar");

            entity.HasIndex(e => e.DiscoverLimitedRewardId, "galaxy_dust_api_discoverli_discover_limited_reward_id_fdbf5ee2");

            entity.HasIndex(e => e.StarId, "galaxy_dust_api_discoverlimitedrewardstar_star_id_4142d2c4");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DiscoverLimitedRewardId).HasColumnName("discover_limited_reward_id");
            entity.Property(e => e.Probability).HasColumnName("probability");
            entity.Property(e => e.StarId).HasColumnName("star_id");

            entity.HasOne(d => d.DiscoverLimitedReward).WithMany(p => p.GalaxyDustApiDiscoverlimitedrewardstars)
                .HasForeignKey(d => d.DiscoverLimitedRewardId)
                .HasConstraintName("galaxy_dust_api_disc_discover_limited_rew_fdbf5ee2_fk_galaxy_du");

            entity.HasOne(d => d.Star).WithMany(p => p.GalaxyDustApiDiscoverlimitedrewardstars)
                .HasForeignKey(d => d.StarId)
                .HasConstraintName("galaxy_dust_api_disc_star_id_4142d2c4_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiDiscoverlimitedrewardstat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_discoverlimitedrewardstat_pkey");

            entity.ToTable("galaxy_dust_api_discoverlimitedrewardstat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
        });

        modelBuilder.Entity<GalaxyDustApiDiscoverlimitedrewardstatcurrency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_discoverlimitedrewardstatcurrency_pkey");

            entity.ToTable("galaxy_dust_api_discoverlimitedrewardstatcurrency");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_discoverli_currency_id_1bc1a765");

            entity.HasIndex(e => e.RewardStatId, "galaxy_dust_api_discoverli_reward_stat_id_d2718a91");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CurrencyAmount).HasColumnName("currency_amount");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.RewardStatId).HasColumnName("reward_stat_id");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiDiscoverlimitedrewardstatcurrencies)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("galaxy_dust_api_disc_currency_id_1bc1a765_fk_galaxy_du");

            entity.HasOne(d => d.RewardStat).WithMany(p => p.GalaxyDustApiDiscoverlimitedrewardstatcurrencies)
                .HasForeignKey(d => d.RewardStatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_disc_reward_stat_id_d2718a91_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiDiscoverlimitedrewardstatitem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_discoverlimitedrewardstatitem_pkey");

            entity.ToTable("galaxy_dust_api_discoverlimitedrewardstatitem");

            entity.HasIndex(e => e.ItemToRewardId, "galaxy_dust_api_discoverli_item_to_reward_id_a37d3531");

            entity.HasIndex(e => e.RewardStatId, "galaxy_dust_api_discoverli_reward_stat_id_41d2fd71");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemToRewardId).HasColumnName("item_to_reward_id");
            entity.Property(e => e.NumberOfItems).HasColumnName("number_of_items");
            entity.Property(e => e.RewardStatId).HasColumnName("reward_stat_id");

            entity.HasOne(d => d.ItemToReward).WithMany(p => p.GalaxyDustApiDiscoverlimitedrewardstatitems)
                .HasForeignKey(d => d.ItemToRewardId)
                .HasConstraintName("galaxy_dust_api_disc_item_to_reward_id_a37d3531_fk_galaxy_du");

            entity.HasOne(d => d.RewardStat).WithMany(p => p.GalaxyDustApiDiscoverlimitedrewardstatitems)
                .HasForeignKey(d => d.RewardStatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_disc_reward_stat_id_41d2fd71_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiDiscoverrewardplanet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_discoverrewardplanet_pkey");

            entity.ToTable("galaxy_dust_api_discoverrewardplanet");

            entity.HasIndex(e => e.DiscoverRewardId, "galaxy_dust_api_discoverre_discover_reward_id_5d5c421d");

            entity.HasIndex(e => e.PlanetId, "galaxy_dust_api_discoverrewardplanet_planet_id_998eff4a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DiscoverRewardId).HasColumnName("discover_reward_id");
            entity.Property(e => e.PlanetId).HasColumnName("planet_id");

            entity.HasOne(d => d.DiscoverReward).WithMany(p => p.GalaxyDustApiDiscoverrewardplanets)
                .HasForeignKey(d => d.DiscoverRewardId)
                .HasConstraintName("galaxy_dust_api_disc_discover_reward_id_5d5c421d_fk_galaxy_du");

            entity.HasOne(d => d.Planet).WithMany(p => p.GalaxyDustApiDiscoverrewardplanets)
                .HasForeignKey(d => d.PlanetId)
                .HasConstraintName("galaxy_dust_api_disc_planet_id_998eff4a_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiDiscoverrewardstar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_discoverrewardstar_pkey");

            entity.ToTable("galaxy_dust_api_discoverrewardstar");

            entity.HasIndex(e => e.DiscoverRewardId, "galaxy_dust_api_discoverrewardstar_discover_reward_id_f37e7f81");

            entity.HasIndex(e => e.StarId, "galaxy_dust_api_discoverrewardstar_star_id_c5d52657");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DiscoverRewardId).HasColumnName("discover_reward_id");
            entity.Property(e => e.StarId).HasColumnName("star_id");

            entity.HasOne(d => d.DiscoverReward).WithMany(p => p.GalaxyDustApiDiscoverrewardstars)
                .HasForeignKey(d => d.DiscoverRewardId)
                .HasConstraintName("galaxy_dust_api_disc_discover_reward_id_f37e7f81_fk_galaxy_du");

            entity.HasOne(d => d.Star).WithMany(p => p.GalaxyDustApiDiscoverrewardstars)
                .HasForeignKey(d => d.StarId)
                .HasConstraintName("galaxy_dust_api_disc_star_id_c5d52657_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiDiscoverrewardstat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_discoverrewardstat_pkey");

            entity.ToTable("galaxy_dust_api_discoverrewardstat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiDiscoverrewardstatcurrency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_discoverrewardstatcurrency_pkey");

            entity.ToTable("galaxy_dust_api_discoverrewardstatcurrency");

            entity.HasIndex(e => e.RewardStatId, "galaxy_dust_api_discoverre_reward_stat_id_7e376630");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_discoverrewardstatcurrency_currency_id_23b157a4");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CurrencyAmount).HasColumnName("currency_amount");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.RewardStatId).HasColumnName("reward_stat_id");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiDiscoverrewardstatcurrencies)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("galaxy_dust_api_disc_currency_id_23b157a4_fk_galaxy_du");

            entity.HasOne(d => d.RewardStat).WithMany(p => p.GalaxyDustApiDiscoverrewardstatcurrencies)
                .HasForeignKey(d => d.RewardStatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_disc_reward_stat_id_7e376630_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiDiscoverrewardstatitem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_discoverrewardstatitem_pkey");

            entity.ToTable("galaxy_dust_api_discoverrewardstatitem");

            entity.HasIndex(e => e.ItemToRewardId, "galaxy_dust_api_discoverre_item_to_reward_id_230ca8a1");

            entity.HasIndex(e => e.RewardStatId, "galaxy_dust_api_discoverrewardstatitem_reward_stat_id_dc1950c9");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemToRewardId).HasColumnName("item_to_reward_id");
            entity.Property(e => e.NumberOfItems).HasColumnName("number_of_items");
            entity.Property(e => e.RewardStatId).HasColumnName("reward_stat_id");

            entity.HasOne(d => d.ItemToReward).WithMany(p => p.GalaxyDustApiDiscoverrewardstatitems)
                .HasForeignKey(d => d.ItemToRewardId)
                .HasConstraintName("galaxy_dust_api_disc_item_to_reward_id_230ca8a1_fk_galaxy_du");

            entity.HasOne(d => d.RewardStat).WithMany(p => p.GalaxyDustApiDiscoverrewardstatitems)
                .HasForeignKey(d => d.RewardStatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_disc_reward_stat_id_dc1950c9_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiDominationskill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_dominationskill_pkey");

            entity.ToTable("galaxy_dust_api_dominationskill");

            entity.HasIndex(e => e.SkillTypeId, "galaxy_dust_api_dominationskill_skill_type_id_a2640362");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivationProbability).HasColumnName("activation_probability");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.SkillTypeId).HasColumnName("skill_type_id");
            entity.Property(e => e.Stack).HasColumnName("stack");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.SkillType).WithMany(p => p.GalaxyDustApiDominationskills)
                .HasForeignKey(d => d.SkillTypeId)
                .HasConstraintName("galaxy_dust_api_domi_skill_type_id_a2640362_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiEmailverification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_emailverification_pkey");

            entity.ToTable("galaxy_dust_api_emailverification");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_emailverification_account_id_705facab");

            entity.HasIndex(e => e.Token, "galaxy_dust_api_emailverification_token_ccb5e63e_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Token, "galaxy_dust_api_emailverification_token_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Token)
                .HasMaxLength(64)
                .HasColumnName("token");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiEmailverifications)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_emai_account_id_705facab_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiEnemyship>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_enemyship_pkey");

            entity.ToTable("galaxy_dust_api_enemyship");

            entity.HasIndex(e => e.EnemyTypeId, "galaxy_dust_api_enemyship_enemy_type_id_099aa112");

            entity.HasIndex(e => e.FleetGroupId, "galaxy_dust_api_enemyship_fleet_group_id_7a4d4210");

            entity.HasIndex(e => e.ShipId, "galaxy_dust_api_enemyship_ship_id_625f5f53");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EnemyTypeId).HasColumnName("enemy_type_id");
            entity.Property(e => e.FleetGroupId).HasColumnName("fleet_group_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.ShipId).HasColumnName("ship_id");

            entity.HasOne(d => d.EnemyType).WithMany(p => p.GalaxyDustApiEnemyships)
                .HasForeignKey(d => d.EnemyTypeId)
                .HasConstraintName("galaxy_dust_api_enem_enemy_type_id_099aa112_fk_galaxy_du");

            entity.HasOne(d => d.FleetGroup).WithMany(p => p.GalaxyDustApiEnemyships)
                .HasForeignKey(d => d.FleetGroupId)
                .HasConstraintName("galaxy_dust_api_enem_fleet_group_id_7a4d4210_fk_galaxy_du");

            entity.HasOne(d => d.Ship).WithMany(p => p.GalaxyDustApiEnemyships)
                .HasForeignKey(d => d.ShipId)
                .HasConstraintName("galaxy_dust_api_enem_ship_id_625f5f53_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiEnemytype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_enemytype_pkey");

            entity.ToTable("galaxy_dust_api_enemytype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiEngine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_engine_pkey");

            entity.ToTable("galaxy_dust_api_engine");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiEssencestat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_essencestat_pkey");

            entity.ToTable("galaxy_dust_api_essencestat");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_essencestat_item_id_key").IsUnique();

            entity.HasIndex(e => e.RarityId, "galaxy_dust_api_essencestat_rarity_id_0eaaf416");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.FileDirection)
                .HasMaxLength(200)
                .HasColumnName("file_direction");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.RarityId).HasColumnName("rarity_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Item).WithOne(p => p.GalaxyDustApiEssencestat)
                .HasForeignKey<GalaxyDustApiEssencestat>(d => d.ItemId)
                .HasConstraintName("galaxy_dust_api_esse_item_id_f6c9aeac_fk_galaxy_du");

            entity.HasOne(d => d.Rarity).WithMany(p => p.GalaxyDustApiEssencestats)
                .HasForeignKey(d => d.RarityId)
                .HasConstraintName("galaxy_dust_api_esse_rarity_id_0eaaf416_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiEssencetype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_essencetype_pkey");

            entity.ToTable("galaxy_dust_api_essencetype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiEssencetypegroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_essencetypegroup_pkey");

            entity.ToTable("galaxy_dust_api_essencetypegroup");

            entity.HasIndex(e => e.EssenceId, "galaxy_dust_api_essencetypegroup_essence_id_e45bdd33");

            entity.HasIndex(e => e.EssenceTypeId, "galaxy_dust_api_essencetypegroup_essence_type_id_cd9809ac");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.EssenceId).HasColumnName("essence_id");
            entity.Property(e => e.EssenceTypeId).HasColumnName("essence_type_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Essence).WithMany(p => p.GalaxyDustApiEssencetypegroups)
                .HasForeignKey(d => d.EssenceId)
                .HasConstraintName("galaxy_dust_api_esse_essence_id_e45bdd33_fk_galaxy_du");

            entity.HasOne(d => d.EssenceType).WithMany(p => p.GalaxyDustApiEssencetypegroups)
                .HasForeignKey(d => d.EssenceTypeId)
                .HasConstraintName("galaxy_dust_api_esse_essence_type_id_cd9809ac_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_event_pkey");

            entity.ToTable("galaxy_dust_api_event");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<GalaxyDustApiExpeditionskill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_expeditionskill_pkey");

            entity.ToTable("galaxy_dust_api_expeditionskill");

            entity.HasIndex(e => e.SkillTypeId, "galaxy_dust_api_expeditionskill_skill_type_id_76c92e1a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivationProbability).HasColumnName("activation_probability");
            entity.Property(e => e.AlwaysProducesCrystalPoints).HasColumnName("always_produces_crystal_points");
            entity.Property(e => e.AlwaysProducesMetalPoints).HasColumnName("always_produces_metal_points");
            entity.Property(e => e.AstrobotSlots).HasColumnName("astrobot_slots");
            entity.Property(e => e.BetterCleanse).HasColumnName("better_cleanse");
            entity.Property(e => e.ChanceToDoubleExpeditionRewardsPercentage).HasColumnName("chance_to_double_expedition_rewards_percentage");
            entity.Property(e => e.ChanceToRepairFleetPercentage).HasColumnName("chance_to_repair_fleet_percentage");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.ExpeditionCostPercentage).HasColumnName("expedition_cost_percentage");
            entity.Property(e => e.ExpeditionRewardsPercentage).HasColumnName("expedition_rewards_percentage");
            entity.Property(e => e.FleefLaserAttackPercentage).HasColumnName("fleef_laser_attack_percentage");
            entity.Property(e => e.FleetAllAttacksPercentage).HasColumnName("fleet_all_attacks_percentage");
            entity.Property(e => e.FleetAttackPercentage).HasColumnName("fleet_attack_percentage");
            entity.Property(e => e.FleetCapacityPercentage).HasColumnName("fleet_capacity_percentage");
            entity.Property(e => e.FleetCapacityPoints).HasColumnName("fleet_capacity_points");
            entity.Property(e => e.FleetCargoPercentage).HasColumnName("fleet_cargo_percentage");
            entity.Property(e => e.FleetCargoPoints).HasColumnName("fleet_cargo_points");
            entity.Property(e => e.FleetDefensePercentage).HasColumnName("fleet_defense_percentage");
            entity.Property(e => e.FleetGravitonAttackPercentage).HasColumnName("fleet_graviton_attack_percentage");
            entity.Property(e => e.FleetIonicAttackPercentage).HasColumnName("fleet_ionic_attack_percentage");
            entity.Property(e => e.FleetPlasmaAttackPercentage).HasColumnName("fleet_plasma_attack_percentage");
            entity.Property(e => e.FleetShieldPercentage).HasColumnName("fleet_shield_percentage");
            entity.Property(e => e.FleetShieldPoints).HasColumnName("fleet_shield_points");
            entity.Property(e => e.FleetSpeedPercentage).HasColumnName("fleet_speed_percentage");
            entity.Property(e => e.GalaxyBladeObliteration).HasColumnName("galaxy_blade_obliteration");
            entity.Property(e => e.GoraRevengePercentage).HasColumnName("gora_revenge_percentage");
            entity.Property(e => e.GravitonDefensePercentage).HasColumnName("graviton_defense_percentage");
            entity.Property(e => e.InstantTravelPercentage).HasColumnName("instant_travel_percentage");
            entity.Property(e => e.InvinciblePercentage).HasColumnName("invincible_percentage");
            entity.Property(e => e.KalvacAttacker).HasColumnName("kalvac_attacker");
            entity.Property(e => e.KalvacExplorer).HasColumnName("kalvac_explorer");
            entity.Property(e => e.KalvacHealer).HasColumnName("kalvac_healer");
            entity.Property(e => e.KalvacTransporter).HasColumnName("kalvac_transporter");
            entity.Property(e => e.LaserDefensePercentage).HasColumnName("laser_defense_percentage");
            entity.Property(e => e.LuxCleaningGd).HasColumnName("lux_cleaning_gd");
            entity.Property(e => e.LuxProductionGd).HasColumnName("lux_production_gd");
            entity.Property(e => e.LuxTicketsGd).HasColumnName("lux_tickets_gd");
            entity.Property(e => e.LuxTravelGd).HasColumnName("lux_travel_gd");
            entity.Property(e => e.MagnusArmour).HasColumnName("magnus_armour");
            entity.Property(e => e.MagnusBlessing).HasColumnName("magnus_blessing");
            entity.Property(e => e.MagnusLightSpeed).HasColumnName("magnus_light_speed");
            entity.Property(e => e.MaxFleetDefensePercentage).HasColumnName("max_fleet_defense_percentage");
            entity.Property(e => e.MaxFleetSpeedPercentage).HasColumnName("max_fleet_speed_percentage");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.NovaDefensePercentage).HasColumnName("nova_defense_percentage");
            entity.Property(e => e.OriginalNovaPercentage).HasColumnName("original_nova_percentage");
            entity.Property(e => e.ProductionBoostCrystalPercentage).HasColumnName("production_boost_crystal_percentage");
            entity.Property(e => e.ProductionBoostDeuteriumPercentage).HasColumnName("production_boost_deuterium_percentage");
            entity.Property(e => e.ProductionBoostMetalPercentage).HasColumnName("production_boost_metal_percentage");
            entity.Property(e => e.ProductionPerExpeditionDeuteriumPercentage).HasColumnName("production_per_expedition_deuterium_percentage");
            entity.Property(e => e.ReduceFleetSpeedHiperspaceShipsPercentage).HasColumnName("reduce_fleet_speed_hiperspace_ships_percentage");
            entity.Property(e => e.ReflectAttackPercentage).HasColumnName("reflect_attack_percentage");
            entity.Property(e => e.ReflectDebuffPercentage).HasColumnName("reflect_debuff_percentage");
            entity.Property(e => e.RepairFleetPercentage).HasColumnName("repair_fleet_percentage");
            entity.Property(e => e.ShieldDamagePercentage).HasColumnName("shield_damage_percentage");
            entity.Property(e => e.SkillTypeId).HasColumnName("skill_type_id");
            entity.Property(e => e.Stack).HasColumnName("stack");
            entity.Property(e => e.StingSwarmg).HasColumnName("sting_swarmg");
            entity.Property(e => e.TravelToAnySector).HasColumnName("travel_to_any_sector");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.ZeusRampage).HasColumnName("zeus_rampage");
            entity.Property(e => e.ZeusSpark).HasColumnName("zeus_spark");

            entity.HasOne(d => d.SkillType).WithMany(p => p.GalaxyDustApiExpeditionskills)
                .HasForeignKey(d => d.SkillTypeId)
                .HasConstraintName("galaxy_dust_api_expe_skill_type_id_76c92e1a_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiExplorationskill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_explorationskill_pkey");

            entity.ToTable("galaxy_dust_api_explorationskill");

            entity.HasIndex(e => e.SkillTypeId, "galaxy_dust_api_explorationskill_skill_type_id_b73a08e0");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivationProbability).HasColumnName("activation_probability");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PhantomFindPercentage).HasColumnName("phantom_find_percentage");
            entity.Property(e => e.SkillTypeId).HasColumnName("skill_type_id");
            entity.Property(e => e.Stack).HasColumnName("stack");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.SkillType).WithMany(p => p.GalaxyDustApiExplorationskills)
                .HasForeignKey(d => d.SkillTypeId)
                .HasConstraintName("galaxy_dust_api_expl_skill_type_id_b73a08e0_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiFirstglobaldiscoverrewardstar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_firstglobaldiscoverrewardstar_pkey");

            entity.ToTable("galaxy_dust_api_firstglobaldiscoverrewardstar");

            entity.HasIndex(e => e.FirstGlobalDiscoverRewardId, "galaxy_dust_api_firstgloba_first_global_discover_rewa_458a0f98");

            entity.HasIndex(e => e.StarId, "galaxy_dust_api_firstglobaldiscoverrewardstar_star_id_713b3c02");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstGlobalDiscoverRewardId).HasColumnName("first_global_discover_reward_id");
            entity.Property(e => e.StarId).HasColumnName("star_id");

            entity.HasOne(d => d.FirstGlobalDiscoverReward).WithMany(p => p.GalaxyDustApiFirstglobaldiscoverrewardstars)
                .HasForeignKey(d => d.FirstGlobalDiscoverRewardId)
                .HasConstraintName("galaxy_dust_api_firs_first_global_discove_458a0f98_fk_galaxy_du");

            entity.HasOne(d => d.Star).WithMany(p => p.GalaxyDustApiFirstglobaldiscoverrewardstars)
                .HasForeignKey(d => d.StarId)
                .HasConstraintName("galaxy_dust_api_firs_star_id_713b3c02_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiFirstglobaldiscoverrewardstat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_firstglobaldiscoverrewardstat_pkey");

            entity.ToTable("galaxy_dust_api_firstglobaldiscoverrewardstat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiFirstglobaldiscoverrewardstatcurrency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_firstglobaldiscoverrewardstatcurrency_pkey");

            entity.ToTable("galaxy_dust_api_firstglobaldiscoverrewardstatcurrency");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_firstgloba_currency_id_ab2dd0a7");

            entity.HasIndex(e => e.RewardStatId, "galaxy_dust_api_firstgloba_reward_stat_id_49f19860");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CurrencyAmount).HasColumnName("currency_amount");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.RewardStatId).HasColumnName("reward_stat_id");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiFirstglobaldiscoverrewardstatcurrencies)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("galaxy_dust_api_firs_currency_id_ab2dd0a7_fk_galaxy_du");

            entity.HasOne(d => d.RewardStat).WithMany(p => p.GalaxyDustApiFirstglobaldiscoverrewardstatcurrencies)
                .HasForeignKey(d => d.RewardStatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_firs_reward_stat_id_49f19860_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiFirstglobaldiscoverrewardstatitem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_firstglobaldiscoverrewardstatitem_pkey");

            entity.ToTable("galaxy_dust_api_firstglobaldiscoverrewardstatitem");

            entity.HasIndex(e => e.ItemToRewardId, "galaxy_dust_api_firstgloba_item_to_reward_id_39a41317");

            entity.HasIndex(e => e.RewardStatId, "galaxy_dust_api_firstgloba_reward_stat_id_6658b724");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemToRewardId).HasColumnName("item_to_reward_id");
            entity.Property(e => e.NumberOfItems).HasColumnName("number_of_items");
            entity.Property(e => e.RewardStatId).HasColumnName("reward_stat_id");

            entity.HasOne(d => d.ItemToReward).WithMany(p => p.GalaxyDustApiFirstglobaldiscoverrewardstatitems)
                .HasForeignKey(d => d.ItemToRewardId)
                .HasConstraintName("galaxy_dust_api_firs_item_to_reward_id_39a41317_fk_galaxy_du");

            entity.HasOne(d => d.RewardStat).WithMany(p => p.GalaxyDustApiFirstglobaldiscoverrewardstatitems)
                .HasForeignKey(d => d.RewardStatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_firs_reward_stat_id_6658b724_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiFleetaccountactiveskill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_fleetaccountactiveskill_pkey");

            entity.ToTable("galaxy_dust_api_fleetaccountactiveskill");

            entity.HasIndex(e => e.FleetGroupId, "galaxy_dust_api_fleetaccountactiveskill_fleet_group_id_dd67697c");

            entity.HasIndex(e => e.SkillId, "galaxy_dust_api_fleetaccountactiveskill_skill_id_0f0fb3ae");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.FleetGroupId).HasColumnName("fleet_group_id");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.SkillId).HasColumnName("skill_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.FleetGroup).WithMany(p => p.GalaxyDustApiFleetaccountactiveskills)
                .HasForeignKey(d => d.FleetGroupId)
                .HasConstraintName("galaxy_dust_api_flee_fleet_group_id_dd67697c_fk_galaxy_du");

            entity.HasOne(d => d.Skill).WithMany(p => p.GalaxyDustApiFleetaccountactiveskills)
                .HasForeignKey(d => d.SkillId)
                .HasConstraintName("galaxy_dust_api_flee_skill_id_0f0fb3ae_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiFleetevent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_fleetevent_pkey");

            entity.ToTable("galaxy_dust_api_fleetevent");

            entity.HasIndex(e => e.DamageTypeId, "galaxy_dust_api_fleetevent_damage_type_id_cbbc8ccb");

            entity.HasIndex(e => e.FleetGroupNpcId, "galaxy_dust_api_fleetevent_fleet_group_npc_id_45ec35fb");

            entity.HasIndex(e => e.StelarBodyId, "galaxy_dust_api_fleetevent_stelar_body_id_a6bb1f12");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Damage).HasColumnName("damage");
            entity.Property(e => e.DamagePercent).HasColumnName("damage_percent");
            entity.Property(e => e.DamageTypeId).HasColumnName("damage_type_id");
            entity.Property(e => e.FleetGroupNpcId).HasColumnName("fleet_group_npc_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.ProbabilityOfHappens).HasColumnName("probability_of_happens");
            entity.Property(e => e.RecoverLife).HasColumnName("recover_life");
            entity.Property(e => e.RecoverLifePercent).HasColumnName("recover_life_percent");
            entity.Property(e => e.StelarBodyId).HasColumnName("stelar_body_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.DamageType).WithMany(p => p.GalaxyDustApiFleetevents)
                .HasForeignKey(d => d.DamageTypeId)
                .HasConstraintName("galaxy_dust_api_flee_damage_type_id_cbbc8ccb_fk_galaxy_du");

            entity.HasOne(d => d.FleetGroupNpc).WithMany(p => p.GalaxyDustApiFleetevents)
                .HasForeignKey(d => d.FleetGroupNpcId)
                .HasConstraintName("galaxy_dust_api_flee_fleet_group_npc_id_45ec35fb_fk_galaxy_du");

            entity.HasOne(d => d.StelarBody).WithMany(p => p.GalaxyDustApiFleetevents)
                .HasForeignKey(d => d.StelarBodyId)
                .HasConstraintName("galaxy_dust_api_flee_stelar_body_id_a6bb1f12_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiFleeteventcurrency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_fleeteventcurrency_pkey");

            entity.ToTable("galaxy_dust_api_fleeteventcurrency");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_fleeteventcurrency_currency_id_f7963777");

            entity.HasIndex(e => e.EventId, "galaxy_dust_api_fleeteventcurrency_event_id_2a459dcc");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CurrencyAmount).HasColumnName("currency_amount");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.EventId).HasColumnName("event_id");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiFleeteventcurrencies)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("galaxy_dust_api_flee_currency_id_f7963777_fk_galaxy_du");

            entity.HasOne(d => d.Event).WithMany(p => p.GalaxyDustApiFleeteventcurrencies)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_flee_event_id_2a459dcc_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiFleeteventitem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_fleeteventitem_pkey");

            entity.ToTable("galaxy_dust_api_fleeteventitem");

            entity.HasIndex(e => e.EventId, "galaxy_dust_api_fleeteventitem_event_id_f9240d42");

            entity.HasIndex(e => e.ItemToRewardId, "galaxy_dust_api_fleeteventitem_item_to_reward_id_4722edb0");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.ItemToRewardId).HasColumnName("item_to_reward_id");
            entity.Property(e => e.NumberOfItems).HasColumnName("number_of_items");

            entity.HasOne(d => d.Event).WithMany(p => p.GalaxyDustApiFleeteventitems)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_flee_event_id_f9240d42_fk_galaxy_du");

            entity.HasOne(d => d.ItemToReward).WithMany(p => p.GalaxyDustApiFleeteventitems)
                .HasForeignKey(d => d.ItemToRewardId)
                .HasConstraintName("galaxy_dust_api_flee_item_to_reward_id_4722edb0_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiFleetgroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_fleetgroup_pkey");

            entity.ToTable("galaxy_dust_api_fleetgroup");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_fleetgroup_account_id_cea0a70c");

            entity.HasIndex(e => e.LicenseId, "galaxy_dust_api_fleetgroup_license_id_9215a07a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.FreeSpace).HasColumnName("free_space");
            entity.Property(e => e.LicenseId).HasColumnName("license_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.UsedSpace).HasColumnName("used_space");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiFleetgroups)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_flee_account_id_cea0a70c_fk_galaxy_du");

            entity.HasOne(d => d.License).WithMany(p => p.GalaxyDustApiFleetgroups)
                .HasForeignKey(d => d.LicenseId)
                .HasConstraintName("galaxy_dust_api_flee_license_id_9215a07a_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiFleetgroupnpc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_fleetgroupnpc_pkey");

            entity.ToTable("galaxy_dust_api_fleetgroupnpc");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<GalaxyDustApiFleetimage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_fleetimage_pkey");

            entity.ToTable("galaxy_dust_api_fleetimage");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FileDirection)
                .HasMaxLength(200)
                .HasColumnName("file_direction");
            entity.Property(e => e.FleetSpace).HasColumnName("fleet_space");
        });

        modelBuilder.Entity<GalaxyDustApiFlyrequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_flyrequirement_pkey");

            entity.ToTable("galaxy_dust_api_flyrequirement");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_flyrequirement_item_id_624b7175");

            entity.HasIndex(e => e.StelarBodyId, "galaxy_dust_api_flyrequirement_stelar_body_id_2aa53ea8");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ItemLevel).HasColumnName("item_level");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.StelarBodyId).HasColumnName("stelar_body_id");

            entity.HasOne(d => d.Item).WithMany(p => p.GalaxyDustApiFlyrequirements)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("galaxy_dust_api_flyr_item_id_624b7175_fk_galaxy_du");

            entity.HasOne(d => d.StelarBody).WithMany(p => p.GalaxyDustApiFlyrequirements)
                .HasForeignKey(d => d.StelarBodyId)
                .HasConstraintName("galaxy_dust_api_flyr_stelar_body_id_2aa53ea8_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiFuselage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_fuselage_pkey");

            entity.ToTable("galaxy_dust_api_fuselage");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<GalaxyDustApiFuselagedamagemultiplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_fuselagedamagemultiplier_pkey");

            entity.ToTable("galaxy_dust_api_fuselagedamagemultiplier");

            entity.HasIndex(e => e.FuselageId, "galaxy_dust_api_fuselagedamagemultiplier_fuselage_id_283fd29c");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FuselageId).HasColumnName("fuselage_id");
            entity.Property(e => e.Graviton).HasColumnName("graviton");
            entity.Property(e => e.Ion).HasColumnName("ion");
            entity.Property(e => e.Kinetic).HasColumnName("kinetic");
            entity.Property(e => e.Laser).HasColumnName("laser");
            entity.Property(e => e.Plasma).HasColumnName("plasma");

            entity.HasOne(d => d.Fuselage).WithMany(p => p.GalaxyDustApiFuselagedamagemultipliers)
                .HasForeignKey(d => d.FuselageId)
                .HasConstraintName("galaxy_dust_api_fuse_fuselage_id_283fd29c_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiGalaxy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_galaxy_pkey");

            entity.ToTable("galaxy_dust_api_galaxy");

            entity.HasIndex(e => e.GalaxyClusterId, "galaxy_dust_api_galaxy_galaxy_cluster_id_2ae6687d");

            entity.HasIndex(e => e.StelarBodyId, "galaxy_dust_api_galaxy_stelar_body_id_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Coords)
                .HasMaxLength(255)
                .HasColumnName("coords");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.FleetEventPercentage).HasColumnName("fleet_event_percentage");
            entity.Property(e => e.GalaxyClusterId).HasColumnName("galaxy_cluster_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.NumberOfStarClusters).HasColumnName("number_of_star_clusters");
            entity.Property(e => e.StarDiscoverProbabilityRateMax).HasColumnName("star_discover_probability_rate_max");
            entity.Property(e => e.StarDiscoverProbabilityRateMin).HasColumnName("star_discover_probability_rate_min");
            entity.Property(e => e.StelarBodyId).HasColumnName("stelar_body_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.GalaxyCluster).WithMany(p => p.GalaxyDustApiGalaxies)
                .HasForeignKey(d => d.GalaxyClusterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_gala_galaxy_cluster_id_2ae6687d_fk_galaxy_du");

            entity.HasOne(d => d.StelarBody).WithOne(p => p.GalaxyDustApiGalaxy)
                .HasForeignKey<GalaxyDustApiGalaxy>(d => d.StelarBodyId)
                .HasConstraintName("galaxy_dust_api_gala_stelar_body_id_b66fd9c9_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiGalaxycluster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_galaxycluster_pkey");

            entity.ToTable("galaxy_dust_api_galaxycluster");

            entity.HasIndex(e => e.StelarBodyId, "galaxy_dust_api_galaxycluster_stelar_body_id_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.FleetEventPercentage).HasColumnName("fleet_event_percentage");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.NumberOfGalaxies).HasColumnName("number_of_galaxies");
            entity.Property(e => e.StarDiscoverProbabilityRateMax).HasColumnName("star_discover_probability_rate_max");
            entity.Property(e => e.StarDiscoverProbabilityRateMin).HasColumnName("star_discover_probability_rate_min");
            entity.Property(e => e.StelarBodyId).HasColumnName("stelar_body_id");
            entity.Property(e => e.TravelTimeInMinutes).HasColumnName("travel_time_in_minutes");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.StelarBody).WithOne(p => p.GalaxyDustApiGalaxycluster)
                .HasForeignKey<GalaxyDustApiGalaxycluster>(d => d.StelarBodyId)
                .HasConstraintName("galaxy_dust_api_gala_stelar_body_id_03c7880d_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiGalaxyclustermaxresource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_galaxyclustermaxresource_pkey");

            entity.ToTable("galaxy_dust_api_galaxyclustermaxresource");

            entity.HasIndex(e => e.GalaxyClusterId, "galaxy_dust_api_galaxyclus_galaxy_cluster_id_48c583d6");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_galaxyclustermaxresource_currency_id_32de423b");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.GalaxyClusterId).HasColumnName("galaxy_cluster_id");
            entity.Property(e => e.MaxCurrency).HasColumnName("max_currency");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiGalaxyclustermaxresources)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("galaxy_dust_api_gala_currency_id_32de423b_fk_galaxy_du");

            entity.HasOne(d => d.GalaxyCluster).WithMany(p => p.GalaxyDustApiGalaxyclustermaxresources)
                .HasForeignKey(d => d.GalaxyClusterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_gala_galaxy_cluster_id_48c583d6_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_item_pkey");

            entity.ToTable("galaxy_dust_api_item");

            entity.HasIndex(e => e.ItemActivationFeeGroupId, "galaxy_dust_api_item_item_activation_fee_group_id_a464e510");

            entity.HasIndex(e => e.ItemCategoryId, "galaxy_dust_api_item_item_category_id_c525f3d2");

            entity.HasIndex(e => e.ItemTypeId, "galaxy_dust_api_item_item_type_id_16f57f3b");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.IsNft).HasColumnName("is_nft");
            entity.Property(e => e.ItemActivationFeeGroupId).HasColumnName("item_activation_fee_group_id");
            entity.Property(e => e.ItemCategoryId).HasColumnName("item_category_id");
            entity.Property(e => e.ItemTypeId).HasColumnName("item_type_id");
            entity.Property(e => e.MarketEnabled).HasColumnName("market_enabled");
            entity.Property(e => e.RelatedName)
                .HasMaxLength(255)
                .HasColumnName("related_name");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.ItemActivationFeeGroup).WithMany(p => p.GalaxyDustApiItems)
                .HasForeignKey(d => d.ItemActivationFeeGroupId)
                .HasConstraintName("galaxy_dust_api_item_item_activation_fee__a464e510_fk_galaxy_du");

            entity.HasOne(d => d.ItemCategory).WithMany(p => p.GalaxyDustApiItems)
                .HasForeignKey(d => d.ItemCategoryId)
                .HasConstraintName("galaxy_dust_api_item_item_category_id_c525f3d2_fk_galaxy_du");

            entity.HasOne(d => d.ItemType).WithMany(p => p.GalaxyDustApiItems)
                .HasForeignKey(d => d.ItemTypeId)
                .HasConstraintName("galaxy_dust_api_item_item_type_id_16f57f3b_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiItemactivationfee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_itemactivationfee_pkey");

            entity.ToTable("galaxy_dust_api_itemactivationfee");

            entity.HasIndex(e => e.ItemActivationFeeGroupId, "galaxy_dust_api_itemactiva_item_activation_fee_group__18bc4f70");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_itemactivationfee_currency_id_d38752bd");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_itemactivationfee_item_id_9d13319f");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.ItemActivationFeeGroupId).HasColumnName("item_activation_fee_group_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Price).HasColumnName("price");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiItemactivationfees)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("galaxy_dust_api_item_currency_id_d38752bd_fk_galaxy_du");

            entity.HasOne(d => d.ItemActivationFeeGroup).WithMany(p => p.GalaxyDustApiItemactivationfees)
                .HasForeignKey(d => d.ItemActivationFeeGroupId)
                .HasConstraintName("galaxy_dust_api_item_item_activation_fee__18bc4f70_fk_galaxy_du");

            entity.HasOne(d => d.Item).WithMany(p => p.GalaxyDustApiItemactivationfees)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_item_item_id_9d13319f_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiItemactivationfeegroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_itemactivationfeegroup_pkey");

            entity.ToTable("galaxy_dust_api_itemactivationfeegroup");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Fee).HasColumnName("fee");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<GalaxyDustApiItemastrobotleveluprequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_itemastrobotleveluprequirement_pkey");

            entity.ToTable("galaxy_dust_api_itemastrobotleveluprequirement");

            entity.HasIndex(e => e.RequirementId, "galaxy_dust_api_itemastrob_requirement_id_00e22532");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_itemastrobotleveluprequirement_item_id_13920c04");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsBurnable).HasColumnName("is_burnable");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ItemLevel).HasColumnName("item_level");
            entity.Property(e => e.RequirementId).HasColumnName("requirement_id");

            entity.HasOne(d => d.Item).WithMany(p => p.GalaxyDustApiItemastrobotleveluprequirements)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_item_item_id_13920c04_fk_galaxy_du");

            entity.HasOne(d => d.Requirement).WithMany(p => p.GalaxyDustApiItemastrobotleveluprequirements)
                .HasForeignKey(d => d.RequirementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_item_requirement_id_00e22532_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiItembadgeleveluprequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_itembadgeleveluprequirement_pkey");

            entity.ToTable("galaxy_dust_api_itembadgeleveluprequirement");

            entity.HasIndex(e => e.RequirementId, "galaxy_dust_api_itembadgel_requirement_id_0b18641d");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_itembadgeleveluprequirement_item_id_87f56b59");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsBurnable).HasColumnName("is_burnable");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ItemLevel).HasColumnName("item_level");
            entity.Property(e => e.RequirementId).HasColumnName("requirement_id");

            entity.HasOne(d => d.Item).WithMany(p => p.GalaxyDustApiItembadgeleveluprequirements)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_item_item_id_87f56b59_fk_galaxy_du");

            entity.HasOne(d => d.Requirement).WithMany(p => p.GalaxyDustApiItembadgeleveluprequirements)
                .HasForeignKey(d => d.RequirementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_item_requirement_id_0b18641d_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiItemcategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_itemcategory_pkey");

            entity.ToTable("galaxy_dust_api_itemcategory");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiItemdefenseleveluprequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_itemdefenseleveluprequirement_pkey");

            entity.ToTable("galaxy_dust_api_itemdefenseleveluprequirement");

            entity.HasIndex(e => e.RequirementId, "galaxy_dust_api_itemdefens_requirement_id_4aa46a00");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_itemdefenseleveluprequirement_item_id_199f53af");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsBurnable).HasColumnName("is_burnable");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ItemLevel).HasColumnName("item_level");
            entity.Property(e => e.RequirementId).HasColumnName("requirement_id");

            entity.HasOne(d => d.Item).WithMany(p => p.GalaxyDustApiItemdefenseleveluprequirements)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_item_item_id_199f53af_fk_galaxy_du");

            entity.HasOne(d => d.Requirement).WithMany(p => p.GalaxyDustApiItemdefenseleveluprequirements)
                .HasForeignKey(d => d.RequirementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_item_requirement_id_4aa46a00_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiItemprice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_itemprices_pkey");

            entity.ToTable("galaxy_dust_api_itemprices");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_itemprices_currency_id_5835d951");

            entity.HasIndex(e => e.PhantomShopId, "galaxy_dust_api_itemprices_phantom_shop_id_edbb9b62");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.PhantomShopId).HasColumnName("phantom_shop_id");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiItemprices)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("galaxy_dust_api_item_currency_id_5835d951_fk_galaxy_du");

            entity.HasOne(d => d.PhantomShop).WithMany(p => p.GalaxyDustApiItemprices)
                .HasForeignKey(d => d.PhantomShopId)
                .HasConstraintName("galaxy_dust_api_item_phantom_shop_id_edbb9b62_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiItempricesnft>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_itempricesnft_pkey");

            entity.ToTable("galaxy_dust_api_itempricesnft");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_itempricesnft_currency_id_0592094e");

            entity.HasIndex(e => e.NftShopId, "galaxy_dust_api_itempricesnft_nft_shop_id_bda19ca6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.NftShopId).HasColumnName("nft_shop_id");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiItempricesnfts)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("galaxy_dust_api_item_currency_id_0592094e_fk_galaxy_du");

            entity.HasOne(d => d.NftShop).WithMany(p => p.GalaxyDustApiItempricesnfts)
                .HasForeignKey(d => d.NftShopId)
                .HasConstraintName("galaxy_dust_api_item_nft_shop_id_bda19ca6_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiItemshipleveluprequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_itemshipleveluprequirement_pkey");

            entity.ToTable("galaxy_dust_api_itemshipleveluprequirement");

            entity.HasIndex(e => e.RequirementId, "galaxy_dust_api_itemshiple_requirement_id_79b0d84d");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_itemshipleveluprequirement_item_id_271619dd");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsBurnable).HasColumnName("is_burnable");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ItemLevel).HasColumnName("item_level");
            entity.Property(e => e.RequirementId).HasColumnName("requirement_id");

            entity.HasOne(d => d.Item).WithMany(p => p.GalaxyDustApiItemshipleveluprequirements)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_item_item_id_271619dd_fk_galaxy_du");

            entity.HasOne(d => d.Requirement).WithMany(p => p.GalaxyDustApiItemshipleveluprequirements)
                .HasForeignKey(d => d.RequirementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_item_requirement_id_79b0d84d_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiItemstructureleveluprequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_itemstructureleveluprequirement_pkey");

            entity.ToTable("galaxy_dust_api_itemstructureleveluprequirement");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_itemstruct_item_id_88c41a77");

            entity.HasIndex(e => e.RequirementId, "galaxy_dust_api_itemstruct_requirement_id_53bf8172");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsBurnable).HasColumnName("is_burnable");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ItemLevel).HasColumnName("item_level");
            entity.Property(e => e.RequirementId).HasColumnName("requirement_id");

            entity.HasOne(d => d.Item).WithMany(p => p.GalaxyDustApiItemstructureleveluprequirements)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_item_item_id_88c41a77_fk_galaxy_du");

            entity.HasOne(d => d.Requirement).WithMany(p => p.GalaxyDustApiItemstructureleveluprequirements)
                .HasForeignKey(d => d.RequirementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_item_requirement_id_53bf8172_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiItemtechnologyleveluprequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_itemtechnologyleveluprequirement_pkey");

            entity.ToTable("galaxy_dust_api_itemtechnologyleveluprequirement");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_itemtechno_item_id_17f6193e");

            entity.HasIndex(e => e.RequirementId, "galaxy_dust_api_itemtechno_requirement_id_8597df42");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsBurnable).HasColumnName("is_burnable");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ItemLevel).HasColumnName("item_level");
            entity.Property(e => e.RequirementId).HasColumnName("requirement_id");

            entity.HasOne(d => d.Item).WithMany(p => p.GalaxyDustApiItemtechnologyleveluprequirements)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_item_item_id_17f6193e_fk_galaxy_du");

            entity.HasOne(d => d.Requirement).WithMany(p => p.GalaxyDustApiItemtechnologyleveluprequirements)
                .HasForeignKey(d => d.RequirementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_item_requirement_id_8597df42_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiItemtoolleveluprequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_itemtoolleveluprequirement_pkey");

            entity.ToTable("galaxy_dust_api_itemtoolleveluprequirement");

            entity.HasIndex(e => e.RequirementId, "galaxy_dust_api_itemtoolle_requirement_id_a027160f");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_itemtoolleveluprequirement_item_id_5b787e69");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsBurnable).HasColumnName("is_burnable");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ItemLevel).HasColumnName("item_level");
            entity.Property(e => e.RequirementId).HasColumnName("requirement_id");

            entity.HasOne(d => d.Item).WithMany(p => p.GalaxyDustApiItemtoolleveluprequirements)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_item_item_id_5b787e69_fk_galaxy_du");

            entity.HasOne(d => d.Requirement).WithMany(p => p.GalaxyDustApiItemtoolleveluprequirements)
                .HasForeignKey(d => d.RequirementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_item_requirement_id_a027160f_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiItemtype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_itemtypes_pkey");

            entity.ToTable("galaxy_dust_api_itemtypes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<GalaxyDustApiLicensestat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_licensestat_pkey");

            entity.ToTable("galaxy_dust_api_licensestat");

            entity.HasIndex(e => e.CollectionId, "galaxy_dust_api_licensestat_collection_id_d308fad5");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_licensestat_item_id_key").IsUnique();

            entity.HasIndex(e => e.RarityId, "galaxy_dust_api_licensestat_rarity_id_1f0a528b");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CollectionId).HasColumnName("collection_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.FileDirection)
                .HasMaxLength(200)
                .HasColumnName("file_direction");
            entity.Property(e => e.FreeSpace).HasColumnName("free_space");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.PowerScore).HasColumnName("power_score");
            entity.Property(e => e.RarityId).HasColumnName("rarity_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Collection).WithMany(p => p.GalaxyDustApiLicensestats)
                .HasForeignKey(d => d.CollectionId)
                .HasConstraintName("galaxy_dust_api_lice_collection_id_d308fad5_fk_galaxy_du");

            entity.HasOne(d => d.Item).WithOne(p => p.GalaxyDustApiLicensestat)
                .HasForeignKey<GalaxyDustApiLicensestat>(d => d.ItemId)
                .HasConstraintName("galaxy_dust_api_lice_item_id_563d021b_fk_galaxy_du");

            entity.HasOne(d => d.Rarity).WithMany(p => p.GalaxyDustApiLicensestats)
                .HasForeignKey(d => d.RarityId)
                .HasConstraintName("galaxy_dust_api_lice_rarity_id_1f0a528b_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiLicensetype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_licensetype_pkey");

            entity.ToTable("galaxy_dust_api_licensetype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiLicensetypegroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_licensetypegroup_pkey");

            entity.ToTable("galaxy_dust_api_licensetypegroup");

            entity.HasIndex(e => e.LicenseId, "galaxy_dust_api_licensetypegroup_license_id_fcb6b2f1");

            entity.HasIndex(e => e.LicenseTypeId, "galaxy_dust_api_licensetypegroup_license_type_id_889994c1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.LicenseId).HasColumnName("license_id");
            entity.Property(e => e.LicenseTypeId).HasColumnName("license_type_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.License).WithMany(p => p.GalaxyDustApiLicensetypegroups)
                .HasForeignKey(d => d.LicenseId)
                .HasConstraintName("galaxy_dust_api_lice_license_id_fcb6b2f1_fk_galaxy_du");

            entity.HasOne(d => d.LicenseType).WithMany(p => p.GalaxyDustApiLicensetypegroups)
                .HasForeignKey(d => d.LicenseTypeId)
                .HasConstraintName("galaxy_dust_api_lice_license_type_id_889994c1_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiMarket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_market_pkey");

            entity.ToTable("galaxy_dust_api_market");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_market_account_id_eab37a67");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_market_currency_id_a0b6f3f5");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_market_item_id_97bfd6b1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AccountItemIds).HasColumnName("account_item_ids");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasColumnName("action");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiMarkets)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_mark_account_id_eab37a67_fk_galaxy_du");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiMarkets)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("galaxy_dust_api_mark_currency_id_a0b6f3f5_fk_galaxy_du");

            entity.HasOne(d => d.Item).WithMany(p => p.GalaxyDustApiMarkets)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("galaxy_dust_api_mark_item_id_97bfd6b1_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiMaterializerstat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_materializerstat_pkey");

            entity.ToTable("galaxy_dust_api_materializerstat");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_materializerstat_item_id_key").IsUnique();

            entity.HasIndex(e => e.RarityId, "galaxy_dust_api_materializerstat_rarity_id_e1bd86ca");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.FileDirection)
                .HasMaxLength(200)
                .HasColumnName("file_direction");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.RarityId).HasColumnName("rarity_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.UsableOn).HasColumnName("usable_on");
            entity.Property(e => e.Uses).HasColumnName("uses");

            entity.HasOne(d => d.Item).WithOne(p => p.GalaxyDustApiMaterializerstat)
                .HasForeignKey<GalaxyDustApiMaterializerstat>(d => d.ItemId)
                .HasConstraintName("galaxy_dust_api_mate_item_id_f09c412d_fk_galaxy_du");

            entity.HasOne(d => d.Rarity).WithMany(p => p.GalaxyDustApiMaterializerstats)
                .HasForeignKey(d => d.RarityId)
                .HasConstraintName("galaxy_dust_api_mate_rarity_id_e1bd86ca_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiMaterializertype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_materializertype_pkey");

            entity.ToTable("galaxy_dust_api_materializertype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiMaterializertypegroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_materializertypegroup_pkey");

            entity.ToTable("galaxy_dust_api_materializertypegroup");

            entity.HasIndex(e => e.MaterializerTypeId, "galaxy_dust_api_materializ_materializer_type_id_b4737f5f");

            entity.HasIndex(e => e.MaterializerId, "galaxy_dust_api_materializertypegroup_materializer_id_6d780302");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.MaterializerId).HasColumnName("materializer_id");
            entity.Property(e => e.MaterializerTypeId).HasColumnName("materializer_type_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Materializer).WithMany(p => p.GalaxyDustApiMaterializertypegroups)
                .HasForeignKey(d => d.MaterializerId)
                .HasConstraintName("galaxy_dust_api_mate_materializer_id_6d780302_fk_galaxy_du");

            entity.HasOne(d => d.MaterializerType).WithMany(p => p.GalaxyDustApiMaterializertypegroups)
                .HasForeignKey(d => d.MaterializerTypeId)
                .HasConstraintName("galaxy_dust_api_mate_materializer_type_id_b4737f5f_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiMintednft>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_mintednft_pkey");

            entity.ToTable("galaxy_dust_api_mintednft");

            entity.HasIndex(e => e.AccountToId, "galaxy_dust_api_mintednft_account_to_id_399e0d71");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_mintednft_item_id_ffd0e4c8");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountToId).HasColumnName("account_to_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.DataItem)
                .HasColumnType("character varying")
                .HasColumnName("data_item");
            entity.Property(e => e.FileDirection)
                .HasMaxLength(200)
                .HasColumnName("file_direction");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Name)
                .HasMaxLength(266)
                .HasColumnName("name");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Rarity)
                .HasMaxLength(255)
                .HasColumnName("rarity");
            entity.Property(e => e.TxHash)
                .HasMaxLength(66)
                .HasColumnName("tx_hash");
            entity.Property(e => e.Type)
                .HasColumnType("character varying(500)[]")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.AccountTo).WithMany(p => p.GalaxyDustApiMintednfts)
                .HasForeignKey(d => d.AccountToId)
                .HasConstraintName("galaxy_dust_api_mint_account_to_id_399e0d71_fk_galaxy_du");

            entity.HasOne(d => d.Item).WithMany(p => p.GalaxyDustApiMintednfts)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("galaxy_dust_api_mint_item_id_ffd0e4c8_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiNftshop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_nftshop_pkey");

            entity.ToTable("galaxy_dust_api_nftshop");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_nftshop_item_id_5ca666e9");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Available).HasColumnName("available");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ItemType)
                .HasMaxLength(55)
                .HasColumnName("item_type");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Stock).HasColumnName("stock");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Item).WithMany(p => p.GalaxyDustApiNftshops)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_nfts_item_id_5ca666e9_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiPackreward>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_packreward_pkey");

            entity.ToTable("galaxy_dust_api_packreward");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_packreward_currency_id_e446ef37");

            entity.HasIndex(e => e.ItemToRewardId, "galaxy_dust_api_packreward_item_to_reward_id_b4fe1680");

            entity.HasIndex(e => e.ItemTypeId, "galaxy_dust_api_packreward_item_type_id_5b40dc4c");

            entity.HasIndex(e => e.PackId, "galaxy_dust_api_packreward_pack_id_cf79944f");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.CurrencyAmount).HasColumnName("currency_amount");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.IsRandom).HasColumnName("is_random");
            entity.Property(e => e.ItemToRewardId).HasColumnName("item_to_reward_id");
            entity.Property(e => e.ItemTypeId).HasColumnName("item_type_id");
            entity.Property(e => e.NumberOfItems).HasColumnName("number_of_items");
            entity.Property(e => e.PackId).HasColumnName("pack_id");
            entity.Property(e => e.Percentage).HasColumnName("percentage");
            entity.Property(e => e.RarityNames)
                .HasColumnType("character varying(500)[]")
                .HasColumnName("rarity_names");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiPackrewards)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("galaxy_dust_api_pack_currency_id_e446ef37_fk_galaxy_du");

            entity.HasOne(d => d.ItemToReward).WithMany(p => p.GalaxyDustApiPackrewards)
                .HasForeignKey(d => d.ItemToRewardId)
                .HasConstraintName("galaxy_dust_api_pack_item_to_reward_id_b4fe1680_fk_galaxy_du");

            entity.HasOne(d => d.ItemType).WithMany(p => p.GalaxyDustApiPackrewards)
                .HasForeignKey(d => d.ItemTypeId)
                .HasConstraintName("galaxy_dust_api_pack_item_type_id_5b40dc4c_fk_galaxy_du");

            entity.HasOne(d => d.Pack).WithMany(p => p.GalaxyDustApiPackrewards)
                .HasForeignKey(d => d.PackId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_pack_pack_id_cf79944f_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiPackstat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_packstat_pkey");

            entity.ToTable("galaxy_dust_api_packstat");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_packstat_item_id_key").IsUnique();

            entity.HasIndex(e => e.RarityId, "galaxy_dust_api_packstat_rarity_id_15795713");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.FileDirection)
                .HasMaxLength(200)
                .HasColumnName("file_direction");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.RarityId).HasColumnName("rarity_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Item).WithOne(p => p.GalaxyDustApiPackstat)
                .HasForeignKey<GalaxyDustApiPackstat>(d => d.ItemId)
                .HasConstraintName("galaxy_dust_api_pack_item_id_4d1b03ae_fk_galaxy_du");

            entity.HasOne(d => d.Rarity).WithMany(p => p.GalaxyDustApiPackstats)
                .HasForeignKey(d => d.RarityId)
                .HasConstraintName("galaxy_dust_api_pack_rarity_id_15795713_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiPacktype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_packtype_pkey");

            entity.ToTable("galaxy_dust_api_packtype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiPacktypegroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_packtypegroup_pkey");

            entity.ToTable("galaxy_dust_api_packtypegroup");

            entity.HasIndex(e => e.PackId, "galaxy_dust_api_packtypegroup_pack_id_82f522be");

            entity.HasIndex(e => e.PackTypeId, "galaxy_dust_api_packtypegroup_pack_type_id_163b1918");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.PackId).HasColumnName("pack_id");
            entity.Property(e => e.PackTypeId).HasColumnName("pack_type_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Pack).WithMany(p => p.GalaxyDustApiPacktypegroups)
                .HasForeignKey(d => d.PackId)
                .HasConstraintName("galaxy_dust_api_pack_pack_id_82f522be_fk_galaxy_du");

            entity.HasOne(d => d.PackType).WithMany(p => p.GalaxyDustApiPacktypegroups)
                .HasForeignKey(d => d.PackTypeId)
                .HasConstraintName("galaxy_dust_api_pack_pack_type_id_163b1918_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiPasswordresettoken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_passwordresettoken_pkey");

            entity.ToTable("galaxy_dust_api_passwordresettoken");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_passwordresettoken_account_id_916748ef");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.Created).HasColumnName("created");
            entity.Property(e => e.IsUsed).HasColumnName("is_used");
            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .HasColumnName("token");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiPasswordresettokens)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_pass_account_id_916748ef_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiPhantomshop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_phantomshop_pkey");

            entity.ToTable("galaxy_dust_api_phantomshop");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_phantomshop_item_id_0f2ff331");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Available).HasColumnName("available");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Stock).HasColumnName("stock");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Item).WithMany(p => p.GalaxyDustApiPhantomshops)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_phan_item_id_0f2ff331_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiPlanet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_planet_pkey");

            entity.ToTable("galaxy_dust_api_planet");

            entity.HasIndex(e => e.ColorTypeId, "galaxy_dust_api_planet_color_type_id_1ff35611");

            entity.HasIndex(e => e.FirstDiscovererId, "galaxy_dust_api_planet_first_discoverer_id_b5581700");

            entity.HasIndex(e => e.PlanetStatId, "galaxy_dust_api_planet_planet_stat_id_4e441d30");

            entity.HasIndex(e => e.SecondDiscovererId, "galaxy_dust_api_planet_second_discoverer_id_bb9cac39");

            entity.HasIndex(e => e.StarId, "galaxy_dust_api_planet_star_id_2265b8fa");

            entity.HasIndex(e => e.StelarBodyId, "galaxy_dust_api_planet_stelar_body_id_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Atmosphere).HasColumnName("atmosphere");
            entity.Property(e => e.Circunference).HasColumnName("circunference");
            entity.Property(e => e.ColorTypeId).HasColumnName("color_type_id");
            entity.Property(e => e.Coords)
                .HasMaxLength(255)
                .HasColumnName("coords");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.DiscoveredDate).HasColumnName("discovered_date");
            entity.Property(e => e.FirstDiscovererId).HasColumnName("first_discoverer_id");
            entity.Property(e => e.Gravity).HasColumnName("gravity");
            entity.Property(e => e.Mass).HasColumnName("mass");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.OrbitTime).HasColumnName("orbit_time");
            entity.Property(e => e.PlanetStatId).HasColumnName("planet_stat_id");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.Radiation).HasColumnName("radiation");
            entity.Property(e => e.SecondDiscovererId).HasColumnName("second_discoverer_id");
            entity.Property(e => e.Size).HasColumnName("size");
            entity.Property(e => e.StarId).HasColumnName("star_id");
            entity.Property(e => e.StelarBodyId).HasColumnName("stelar_body_id");
            entity.Property(e => e.Temperature).HasColumnName("temperature");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.ColorType).WithMany(p => p.GalaxyDustApiPlanets)
                .HasForeignKey(d => d.ColorTypeId)
                .HasConstraintName("galaxy_dust_api_plan_color_type_id_1ff35611_fk_galaxy_du");

            entity.HasOne(d => d.FirstDiscoverer).WithMany(p => p.GalaxyDustApiPlanetFirstDiscoverers)
                .HasForeignKey(d => d.FirstDiscovererId)
                .HasConstraintName("galaxy_dust_api_plan_first_discoverer_id_b5581700_fk_galaxy_du");

            entity.HasOne(d => d.PlanetStat).WithMany(p => p.GalaxyDustApiPlanets)
                .HasForeignKey(d => d.PlanetStatId)
                .HasConstraintName("galaxy_dust_api_plan_planet_stat_id_4e441d30_fk_galaxy_du");

            entity.HasOne(d => d.SecondDiscoverer).WithMany(p => p.GalaxyDustApiPlanetSecondDiscoverers)
                .HasForeignKey(d => d.SecondDiscovererId)
                .HasConstraintName("galaxy_dust_api_plan_second_discoverer_id_bb9cac39_fk_galaxy_du");

            entity.HasOne(d => d.Star).WithMany(p => p.GalaxyDustApiPlanets)
                .HasForeignKey(d => d.StarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_plan_star_id_2265b8fa_fk_galaxy_du");

            entity.HasOne(d => d.StelarBody).WithOne(p => p.GalaxyDustApiPlanet)
                .HasForeignKey<GalaxyDustApiPlanet>(d => d.StelarBodyId)
                .HasConstraintName("galaxy_dust_api_plan_stelar_body_id_26db055f_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiPlanetstat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_planetstat_pkey");

            entity.ToTable("galaxy_dust_api_planetstat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AtmosphereMax).HasColumnName("atmosphere_max");
            entity.Property(e => e.AtmosphereMin).HasColumnName("atmosphere_min");
            entity.Property(e => e.CircunferenceMax).HasColumnName("circunference_max");
            entity.Property(e => e.CircunferenceMin).HasColumnName("circunference_min");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.GravityMax).HasColumnName("gravity_max");
            entity.Property(e => e.GravityMin).HasColumnName("gravity_min");
            entity.Property(e => e.MassMax).HasColumnName("mass_max");
            entity.Property(e => e.MassMin).HasColumnName("mass_min");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.OrbitTimeMax).HasColumnName("orbit_time_max");
            entity.Property(e => e.OrbitTimeMin).HasColumnName("orbit_time_min");
            entity.Property(e => e.RadiationMax).HasColumnName("radiation_max");
            entity.Property(e => e.RadiationMin).HasColumnName("radiation_min");
            entity.Property(e => e.SizeRateMax).HasColumnName("size_rate_max");
            entity.Property(e => e.SizeRateMin).HasColumnName("size_rate_min");
            entity.Property(e => e.TemperatureMax).HasColumnName("temperature_max");
            entity.Property(e => e.TemperatureMin).HasColumnName("temperature_min");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<GalaxyDustApiQmpstat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_qmpstat_pkey");

            entity.ToTable("galaxy_dust_api_qmpstat");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_qmpstat_item_id_key").IsUnique();

            entity.HasIndex(e => e.RarityId, "galaxy_dust_api_qmpstat_rarity_id_88c66e7c");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.FileDirection)
                .HasMaxLength(200)
                .HasColumnName("file_direction");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.MaxUses).HasColumnName("max_uses");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.PercentageToFindDestroyedShips).HasColumnName("percentage_to_find_destroyed_ships");
            entity.Property(e => e.RarityId).HasColumnName("rarity_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Item).WithOne(p => p.GalaxyDustApiQmpstat)
                .HasForeignKey<GalaxyDustApiQmpstat>(d => d.ItemId)
                .HasConstraintName("galaxy_dust_api_qmps_item_id_dae355e8_fk_galaxy_du");

            entity.HasOne(d => d.Rarity).WithMany(p => p.GalaxyDustApiQmpstats)
                .HasForeignKey(d => d.RarityId)
                .HasConstraintName("galaxy_dust_api_qmps_rarity_id_88c66e7c_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiQmptype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_qmptype_pkey");

            entity.ToTable("galaxy_dust_api_qmptype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiQmptypegroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_qmptypegroup_pkey");

            entity.ToTable("galaxy_dust_api_qmptypegroup");

            entity.HasIndex(e => e.QmpId, "galaxy_dust_api_qmptypegroup_QMP_id_b8030ea3");

            entity.HasIndex(e => e.QmpTypeId, "galaxy_dust_api_qmptypegroup_QMP_type_id_fd626a2e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.QmpId).HasColumnName("QMP_id");
            entity.Property(e => e.QmpTypeId).HasColumnName("QMP_type_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Qmp).WithMany(p => p.GalaxyDustApiQmptypegroups)
                .HasForeignKey(d => d.QmpId)
                .HasConstraintName("galaxy_dust_api_qmpt_QMP_id_b8030ea3_fk_galaxy_du");

            entity.HasOne(d => d.QmpType).WithMany(p => p.GalaxyDustApiQmptypegroups)
                .HasForeignKey(d => d.QmpTypeId)
                .HasConstraintName("galaxy_dust_api_qmpt_QMP_type_id_fd626a2e_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiRaritytype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_raritytype_pkey");

            entity.ToTable("galaxy_dust_api_raritytype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<GalaxyDustApiRepairkitfee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_repairkitfee_pkey");

            entity.ToTable("galaxy_dust_api_repairkitfee");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_repairkitfee_currency_id_cafbe0e6");

            entity.HasIndex(e => e.RepairKitId, "galaxy_dust_api_repairkitfee_repair_kit_id_f16c7491");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CurrencyAmount).HasColumnName("currency_amount");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.RepairKitId).HasColumnName("repair_kit_id");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiRepairkitfees)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("galaxy_dust_api_repa_currency_id_cafbe0e6_fk_galaxy_du");

            entity.HasOne(d => d.RepairKit).WithMany(p => p.GalaxyDustApiRepairkitfees)
                .HasForeignKey(d => d.RepairKitId)
                .HasConstraintName("galaxy_dust_api_repa_repair_kit_id_f16c7491_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiRepairkitstat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_repairkitstat_pkey");

            entity.ToTable("galaxy_dust_api_repairkitstat");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_repairkitstat_item_id_key").IsUnique();

            entity.HasIndex(e => e.RarityId, "galaxy_dust_api_repairkitstat_rarity_id_e8c505f8");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.FileDirection)
                .HasMaxLength(200)
                .HasColumnName("file_direction");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.RarityId).HasColumnName("rarity_id");
            entity.Property(e => e.TotalHealth).HasColumnName("total_health");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Item).WithOne(p => p.GalaxyDustApiRepairkitstat)
                .HasForeignKey<GalaxyDustApiRepairkitstat>(d => d.ItemId)
                .HasConstraintName("galaxy_dust_api_repa_item_id_289db286_fk_galaxy_du");

            entity.HasOne(d => d.Rarity).WithMany(p => p.GalaxyDustApiRepairkitstats)
                .HasForeignKey(d => d.RarityId)
                .HasConstraintName("galaxy_dust_api_repa_rarity_id_e8c505f8_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiRepairkittype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_repairkittype_pkey");

            entity.ToTable("galaxy_dust_api_repairkittype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiRepairkittypegroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_repairkittypegroup_pkey");

            entity.ToTable("galaxy_dust_api_repairkittypegroup");

            entity.HasIndex(e => e.RepairKitId, "galaxy_dust_api_repairkittypegroup_repair_kit_id_3ae98fbc");

            entity.HasIndex(e => e.RepairKitTypeId, "galaxy_dust_api_repairkittypegroup_repair_kit_type_id_e679bd5a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.RepairKitId).HasColumnName("repair_kit_id");
            entity.Property(e => e.RepairKitTypeId).HasColumnName("repair_kit_type_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.RepairKit).WithMany(p => p.GalaxyDustApiRepairkittypegroups)
                .HasForeignKey(d => d.RepairKitId)
                .HasConstraintName("galaxy_dust_api_repa_repair_kit_id_3ae98fbc_fk_galaxy_du");

            entity.HasOne(d => d.RepairKitType).WithMany(p => p.GalaxyDustApiRepairkittypegroups)
                .HasForeignKey(d => d.RepairKitTypeId)
                .HasConstraintName("galaxy_dust_api_repa_repair_kit_type_id_e679bd5a_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiSerie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_serie_pkey");

            entity.ToTable("galaxy_dust_api_serie");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiShipcategorylevelrequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_shipcategorylevelrequirement_pkey");

            entity.ToTable("galaxy_dust_api_shipcategorylevelrequirement");

            entity.HasIndex(e => e.ItemCategoryId, "galaxy_dust_api_shipcatego_item_category_id_40da5121");

            entity.HasIndex(e => e.ShipLevelUpRequirementId, "galaxy_dust_api_shipcatego_ship_level_up_requirement__e549cfdb");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemCategoryId).HasColumnName("item_category_id");
            entity.Property(e => e.LevelRequired).HasColumnName("level_required");
            entity.Property(e => e.ShipLevelUpRequirementId).HasColumnName("ship_level_up_requirement_id");

            entity.HasOne(d => d.ItemCategory).WithMany(p => p.GalaxyDustApiShipcategorylevelrequirements)
                .HasForeignKey(d => d.ItemCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_ship_item_category_id_40da5121_fk_galaxy_du");

            entity.HasOne(d => d.ShipLevelUpRequirement).WithMany(p => p.GalaxyDustApiShipcategorylevelrequirements)
                .HasForeignKey(d => d.ShipLevelUpRequirementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_ship_ship_level_up_requir_e549cfdb_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiShipfuselagegroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_shipfuselagegroup_pkey");

            entity.ToTable("galaxy_dust_api_shipfuselagegroup");

            entity.HasIndex(e => e.FuselageId, "galaxy_dust_api_shipfuselagegroup_fuselage_id_f33b27f1");

            entity.HasIndex(e => e.ShipId, "galaxy_dust_api_shipfuselagegroup_ship_stat_id_c5f5c0a3");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.FuselageId).HasColumnName("fuselage_id");
            entity.Property(e => e.ShipId).HasColumnName("ship_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Fuselage).WithMany(p => p.GalaxyDustApiShipfuselagegroups)
                .HasForeignKey(d => d.FuselageId)
                .HasConstraintName("galaxy_dust_api_ship_fuselage_id_f33b27f1_fk_galaxy_du");

            entity.HasOne(d => d.Ship).WithMany(p => p.GalaxyDustApiShipfuselagegroups)
                .HasForeignKey(d => d.ShipId)
                .HasConstraintName("galaxy_dust_api_ship_ship_id_dbdd8cf7_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiShipleveluprequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_shipleveluprequirement_pkey");

            entity.ToTable("galaxy_dust_api_shipleveluprequirement");

            entity.HasIndex(e => e.ShipId, "galaxy_dust_api_shipleveluprequirement_ship_id_87cab106");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LevelToEvolve).HasColumnName("level_to_evolve");
            entity.Property(e => e.LevelUpDuration).HasColumnName("level_up_duration");
            entity.Property(e => e.ShipId).HasColumnName("ship_id");

            entity.HasOne(d => d.Ship).WithMany(p => p.GalaxyDustApiShipleveluprequirements)
                .HasForeignKey(d => d.ShipId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_ship_ship_id_87cab106_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiShipsize>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_shipsize_pkey");

            entity.ToTable("galaxy_dust_api_shipsize");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiShipskilllevelgroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_shipskilllevelgroup_pkey");

            entity.ToTable("galaxy_dust_api_shipskilllevelgroup");

            entity.HasIndex(e => e.DominationSkillId, "galaxy_dust_api_shipskilll_domination_skill_id_f07ff535");

            entity.HasIndex(e => e.ExpeditionSkillId, "galaxy_dust_api_shipskilll_expedition_skill_id_5bbd3040");

            entity.HasIndex(e => e.ExplorationSkillId, "galaxy_dust_api_shipskilll_exploration_skill_id_62d0a1a5");

            entity.HasIndex(e => e.BattleSkillId, "galaxy_dust_api_shipskilllevelgroup_battle_skill_id_6c2af7ba");

            entity.HasIndex(e => e.ShipId, "galaxy_dust_api_shipskilllevelgroup_ship_id_950ebf5f");

            entity.HasIndex(e => e.TransportSkillId, "galaxy_dust_api_shipskilllevelgroup_transport_skill_id_b315b6e2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BattleSkillId).HasColumnName("battle_skill_id");
            entity.Property(e => e.BlockGroup).HasColumnName("block_group");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.DominationSkillId).HasColumnName("domination_skill_id");
            entity.Property(e => e.ExpeditionSkillId).HasColumnName("expedition_skill_id");
            entity.Property(e => e.ExplorationSkillId).HasColumnName("exploration_skill_id");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.ShipId).HasColumnName("ship_id");
            entity.Property(e => e.TransportSkillId).HasColumnName("transport_skill_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.BattleSkill).WithMany(p => p.GalaxyDustApiShipskilllevelgroups)
                .HasForeignKey(d => d.BattleSkillId)
                .HasConstraintName("galaxy_dust_api_ship_battle_skill_id_6c2af7ba_fk_galaxy_du");

            entity.HasOne(d => d.DominationSkill).WithMany(p => p.GalaxyDustApiShipskilllevelgroups)
                .HasForeignKey(d => d.DominationSkillId)
                .HasConstraintName("galaxy_dust_api_ship_domination_skill_id_f07ff535_fk_galaxy_du");

            entity.HasOne(d => d.ExpeditionSkill).WithMany(p => p.GalaxyDustApiShipskilllevelgroups)
                .HasForeignKey(d => d.ExpeditionSkillId)
                .HasConstraintName("galaxy_dust_api_ship_expedition_skill_id_5bbd3040_fk_galaxy_du");

            entity.HasOne(d => d.ExplorationSkill).WithMany(p => p.GalaxyDustApiShipskilllevelgroups)
                .HasForeignKey(d => d.ExplorationSkillId)
                .HasConstraintName("galaxy_dust_api_ship_exploration_skill_id_62d0a1a5_fk_galaxy_du");

            entity.HasOne(d => d.Ship).WithMany(p => p.GalaxyDustApiShipskilllevelgroups)
                .HasForeignKey(d => d.ShipId)
                .HasConstraintName("galaxy_dust_api_ship_ship_id_950ebf5f_fk_galaxy_du");

            entity.HasOne(d => d.TransportSkill).WithMany(p => p.GalaxyDustApiShipskilllevelgroups)
                .HasForeignKey(d => d.TransportSkillId)
                .HasConstraintName("galaxy_dust_api_ship_transport_skill_id_b315b6e2_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiShipstat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_shipstat_pkey");

            entity.ToTable("galaxy_dust_api_shipstat");

            entity.HasIndex(e => e.CollectionId, "galaxy_dust_api_shipstat_collection_id_e957259b");

            entity.HasIndex(e => e.CompanyId, "galaxy_dust_api_shipstat_company_id_fea91297");

            entity.HasIndex(e => e.EngineId, "galaxy_dust_api_shipstat_engine_id_a7c0863c");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_shipstat_item_id_key").IsUnique();

            entity.HasIndex(e => e.RarityId, "galaxy_dust_api_shipstat_rarity_id_f5aab9fc");

            entity.HasIndex(e => e.SerieId, "galaxy_dust_api_shipstat_serie_id_82df8b1e");

            entity.HasIndex(e => e.ShipSizeId, "galaxy_dust_api_shipstat_ship_size_id_e9a3780f");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cargo).HasColumnName("cargo");
            entity.Property(e => e.CollectionId).HasColumnName("collection_id");
            entity.Property(e => e.CombatSpeed).HasColumnName("combat_speed");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Defense).HasColumnName("defense");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EngineId).HasColumnName("engine_id");
            entity.Property(e => e.FileDirection)
                .HasMaxLength(200)
                .HasColumnName("file_direction");
            entity.Property(e => e.FleetSpace).HasColumnName("fleet_space");
            entity.Property(e => e.GravitonAttack).HasColumnName("graviton_attack");
            entity.Property(e => e.IonAttack).HasColumnName("ion_attack");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.KineticAttack).HasColumnName("kinetic_attack");
            entity.Property(e => e.LaserAttack).HasColumnName("laser_attack");
            entity.Property(e => e.MaxLevel).HasColumnName("max_level");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PlasmaAttack).HasColumnName("plasma_attack");
            entity.Property(e => e.PowerScore).HasColumnName("power_score");
            entity.Property(e => e.Production).HasColumnName("production");
            entity.Property(e => e.RarityId).HasColumnName("rarity_id");
            entity.Property(e => e.SerieId).HasColumnName("serie_id");
            entity.Property(e => e.Shield).HasColumnName("shield");
            entity.Property(e => e.ShipSizeId).HasColumnName("ship_size_id");
            entity.Property(e => e.Speed).HasColumnName("speed");
            entity.Property(e => e.TotalHealth).HasColumnName("total_health");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Collection).WithMany(p => p.GalaxyDustApiShipstats)
                .HasForeignKey(d => d.CollectionId)
                .HasConstraintName("galaxy_dust_api_ship_collection_id_e957259b_fk_galaxy_du");

            entity.HasOne(d => d.Company).WithMany(p => p.GalaxyDustApiShipstats)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("galaxy_dust_api_ship_company_id_fea91297_fk_galaxy_du");

            entity.HasOne(d => d.Engine).WithMany(p => p.GalaxyDustApiShipstats)
                .HasForeignKey(d => d.EngineId)
                .HasConstraintName("galaxy_dust_api_ship_engine_id_a7c0863c_fk_galaxy_du");

            entity.HasOne(d => d.Item).WithOne(p => p.GalaxyDustApiShipstat)
                .HasForeignKey<GalaxyDustApiShipstat>(d => d.ItemId)
                .HasConstraintName("galaxy_dust_api_ship_item_id_b19b3369_fk_galaxy_du");

            entity.HasOne(d => d.Rarity).WithMany(p => p.GalaxyDustApiShipstats)
                .HasForeignKey(d => d.RarityId)
                .HasConstraintName("galaxy_dust_api_ship_rarity_id_f5aab9fc_fk_galaxy_du");

            entity.HasOne(d => d.Serie).WithMany(p => p.GalaxyDustApiShipstats)
                .HasForeignKey(d => d.SerieId)
                .HasConstraintName("galaxy_dust_api_ship_serie_id_82df8b1e_fk_galaxy_du");

            entity.HasOne(d => d.ShipSize).WithMany(p => p.GalaxyDustApiShipstats)
                .HasForeignKey(d => d.ShipSizeId)
                .HasConstraintName("galaxy_dust_api_ship_ship_size_id_e9a3780f_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiShiptype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_shiptype_pkey");

            entity.ToTable("galaxy_dust_api_shiptype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiShiptypegroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_shiptypegroup_pkey");

            entity.ToTable("galaxy_dust_api_shiptypegroup");

            entity.HasIndex(e => e.ShipId, "galaxy_dust_api_shiptypegroup_ship_id_3aa0a03e");

            entity.HasIndex(e => e.ShipTypeId, "galaxy_dust_api_shiptypegroup_ship_type_id_9c129d1b");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.ShipId).HasColumnName("ship_id");
            entity.Property(e => e.ShipTypeId).HasColumnName("ship_type_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Ship).WithMany(p => p.GalaxyDustApiShiptypegroups)
                .HasForeignKey(d => d.ShipId)
                .HasConstraintName("galaxy_dust_api_ship_ship_id_3aa0a03e_fk_galaxy_du");

            entity.HasOne(d => d.ShipType).WithMany(p => p.GalaxyDustApiShiptypegroups)
                .HasForeignKey(d => d.ShipTypeId)
                .HasConstraintName("galaxy_dust_api_ship_ship_type_id_9c129d1b_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiSkillrequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_skillrequirement_pkey");

            entity.ToTable("galaxy_dust_api_skillrequirement");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_skillrequirement_currency_id_b3944830");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_skillrequirement_item_id_af54ba50");

            entity.HasIndex(e => e.SkillId, "galaxy_dust_api_skillrequirement_skill_id_11232b2b");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CurrencyAmount).HasColumnName("currency_amount");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ItemLevel).HasColumnName("item_level");
            entity.Property(e => e.SkillId).HasColumnName("skill_id");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiSkillrequirements)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("galaxy_dust_api_skil_currency_id_b3944830_fk_galaxy_du");

            entity.HasOne(d => d.Item).WithMany(p => p.GalaxyDustApiSkillrequirements)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("galaxy_dust_api_skil_item_id_af54ba50_fk_galaxy_du");

            entity.HasOne(d => d.Skill).WithMany(p => p.GalaxyDustApiSkillrequirements)
                .HasForeignKey(d => d.SkillId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_skil_skill_id_11232b2b_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiSkillstat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_skillstat_pkey");

            entity.ToTable("galaxy_dust_api_skillstat");

            entity.HasIndex(e => e.SkillTypeId, "galaxy_dust_api_skillstat_skill_type_id_b0d1b5fe");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivationProbability).HasColumnName("activation_probability");
            entity.Property(e => e.AlienCrafterPercentage).HasColumnName("alien_crafter_percentage");
            entity.Property(e => e.AstrobotSlots).HasColumnName("astrobot_slots");
            entity.Property(e => e.AstrobotsMaterialProductionPercentage).HasColumnName("astrobots_material_production_percentage");
            entity.Property(e => e.ChanceOfConsumeHalfDominationSlotsPercentage).HasColumnName("chance_of_consume_half_domination_slots_percentage");
            entity.Property(e => e.ChanceOfExtractingPureGdPercentage).HasColumnName("chance_of_extracting_pure_gd_percentage");
            entity.Property(e => e.ChanceOfRepairFleetUponExpeditionPercentage).HasColumnName("chance_of_repair_fleet_upon_expedition_percentage");
            entity.Property(e => e.CombatSpeedPercentage).HasColumnName("combat_speed_percentage");
            entity.Property(e => e.CombatSpeedPoints).HasColumnName("combat_speed_points");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.CrystalProduction).HasColumnName("crystal_production");
            entity.Property(e => e.CrystalProductionBoostPercentage).HasColumnName("crystal_production_boost_percentage");
            entity.Property(e => e.CrystalProductionPercentage).HasColumnName("crystal_production_percentage");
            entity.Property(e => e.DarkMatterProduction).HasColumnName("dark_matter_production");
            entity.Property(e => e.DarkMatterProductionPercentage).HasColumnName("dark_matter_production_percentage");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.DeuteriumProduction).HasColumnName("deuterium_production");
            entity.Property(e => e.DeuteriumProductionBoostPercentage).HasColumnName("deuterium_production_boost_percentage");
            entity.Property(e => e.DeuteriumProductionPer100kResourcesProduced).HasColumnName("deuterium_production_per_100k_resources_produced");
            entity.Property(e => e.DeuteriumProductionPerExpeditionPercentage).HasColumnName("deuterium_production_per_expedition_percentage");
            entity.Property(e => e.DeuteriumProductionPercentage).HasColumnName("deuterium_production_percentage");
            entity.Property(e => e.DominationFleetSpacePercentage).HasColumnName("domination_fleet_space_percentage");
            entity.Property(e => e.DominationFleetSpacePoints).HasColumnName("domination_fleet_space_points");
            entity.Property(e => e.DominationInstantTravelPercentage).HasColumnName("domination_instant_travel_percentage");
            entity.Property(e => e.DominationResuplyOne).HasColumnName("domination_resuply_one");
            entity.Property(e => e.DuplicatePureGdPercentage).HasColumnName("duplicate_pure_gd_percentage");
            entity.Property(e => e.DuplicateShipOnCreationFromEpicOrRarerBpPercentage).HasColumnName("duplicate_ship_on_creation_from_epic_or_rarer_BP_percentage");
            entity.Property(e => e.DuplicateShipOnCreationPercentage).HasColumnName("duplicate_ship_on_creation_percentage");
            entity.Property(e => e.DuplicateTechnologyAndBuildingsOnCreationPercentage).HasColumnName("duplicate_technology_and_buildings_on_creation_percentage");
            entity.Property(e => e.EnergyProduction).HasColumnName("energy_production");
            entity.Property(e => e.EnergyProductionPercentage).HasColumnName("energy_production_percentage");
            entity.Property(e => e.ExplorationFleetSpacePercentage).HasColumnName("exploration_fleet_space_percentage");
            entity.Property(e => e.ExplorationFleetSpacePoints).HasColumnName("exploration_fleet_space_points");
            entity.Property(e => e.FleetCargoPercentage).HasColumnName("fleet_cargo_percentage");
            entity.Property(e => e.FleetCargoPoints).HasColumnName("fleet_cargo_points");
            entity.Property(e => e.FleetCombatSpeedPercentage).HasColumnName("fleet_combat_speed_percentage");
            entity.Property(e => e.FleetCombatSpeedPoints).HasColumnName("fleet_combat_speed_points");
            entity.Property(e => e.FleetGravitonAttackPercentage).HasColumnName("fleet_graviton_attack_percentage");
            entity.Property(e => e.FleetGravitonAttackPoints).HasColumnName("fleet_graviton_attack_points");
            entity.Property(e => e.FleetGravitonDefensePercentage).HasColumnName("fleet_graviton_defense_percentage");
            entity.Property(e => e.FleetGravitonDefensePoints).HasColumnName("fleet_graviton_defense_points");
            entity.Property(e => e.FleetIonicAttackPercentage).HasColumnName("fleet_ionic_attack_percentage");
            entity.Property(e => e.FleetIonicAttackPoints).HasColumnName("fleet_ionic_attack_points");
            entity.Property(e => e.FleetIonicDefensePercentage).HasColumnName("fleet_ionic_defense_percentage");
            entity.Property(e => e.FleetIonicDefensePoints).HasColumnName("fleet_ionic_defense_points");
            entity.Property(e => e.FleetKineticAttackPercentage).HasColumnName("fleet_kinetic_attack_percentage");
            entity.Property(e => e.FleetKineticAttackPoints).HasColumnName("fleet_kinetic_attack_points");
            entity.Property(e => e.FleetKineticDefensePercentage).HasColumnName("fleet_kinetic_defense_percentage");
            entity.Property(e => e.FleetKineticDefensePoints).HasColumnName("fleet_kinetic_defense_points");
            entity.Property(e => e.FleetLaserAttackPercentage).HasColumnName("fleet_laser_attack_percentage");
            entity.Property(e => e.FleetLaserAttackPoints).HasColumnName("fleet_laser_attack_points");
            entity.Property(e => e.FleetLaserDefensePercentage).HasColumnName("fleet_laser_defense_percentage");
            entity.Property(e => e.FleetLaserDefensePoints).HasColumnName("fleet_laser_defense_points");
            entity.Property(e => e.FleetPlasmaAttackPercentage).HasColumnName("fleet_plasma_attack_percentage");
            entity.Property(e => e.FleetPlasmaAttackPoints).HasColumnName("fleet_plasma_attack_points");
            entity.Property(e => e.FleetPlasmaDefensePercentage).HasColumnName("fleet_plasma_defense_percentage");
            entity.Property(e => e.FleetPlasmaDefensePoints).HasColumnName("fleet_plasma_defense_points");
            entity.Property(e => e.FleetShieldPercentage).HasColumnName("fleet_shield_percentage");
            entity.Property(e => e.FleetShieldPoints).HasColumnName("fleet_shield_points");
            entity.Property(e => e.FleetSpacePercentage).HasColumnName("fleet_space_percentage");
            entity.Property(e => e.FleetSpacePoints).HasColumnName("fleet_space_points");
            entity.Property(e => e.FleetSpeedPercentage).HasColumnName("fleet_speed_percentage");
            entity.Property(e => e.FleetSpeedPoints).HasColumnName("fleet_speed_points");
            entity.Property(e => e.FleetTotalDamagePercentage).HasColumnName("fleet_total_damage_percentage");
            entity.Property(e => e.FleetTotalDamagePoints).HasColumnName("fleet_total_damage_points");
            entity.Property(e => e.FleetTotalDefensePercentage).HasColumnName("fleet_total_defense_percentage");
            entity.Property(e => e.FleetTotalDefensePoints).HasColumnName("fleet_total_defense_points");
            entity.Property(e => e.FreeRepairPercentage).HasColumnName("free_repair_percentage");
            entity.Property(e => e.GalaxyBladeObliterationPercentage).HasColumnName("galaxy_blade_obliteration_percentage");
            entity.Property(e => e.GravitonAttackPercentage).HasColumnName("graviton_attack_percentage");
            entity.Property(e => e.GravitonAttackPoints).HasColumnName("graviton_attack_points");
            entity.Property(e => e.GravitonDefensePercentage).HasColumnName("graviton_defense_percentage");
            entity.Property(e => e.GravitonDefensePoints).HasColumnName("graviton_defense_points");
            entity.Property(e => e.HigherRarityPureGdProductionPercentage).HasColumnName("higher_rarity_pure_gd_production_percentage");
            entity.Property(e => e.IncreasesAttackToAllDefensesPercentage).HasColumnName("increases_attack_to_all_defenses_percentage");
            entity.Property(e => e.IncreasesAttackToAllShipsPercentage).HasColumnName("increases_attack_to_all_ships_percentage");
            entity.Property(e => e.IncreasesBadgeSlots).HasColumnName("increases_badge_slots");
            entity.Property(e => e.IncreasesBaseCrystalCapacity).HasColumnName("increases_base_crystal_capacity");
            entity.Property(e => e.IncreasesBaseDarkMatterCapacity).HasColumnName("increases_base_dark_matter_capacity");
            entity.Property(e => e.IncreasesBaseDefenePercentage).HasColumnName("increases_base_defene_percentage");
            entity.Property(e => e.IncreasesBaseDeuteriumCapacity).HasColumnName("increases_base_deuterium_capacity");
            entity.Property(e => e.IncreasesBaseMetalCapacity).HasColumnName("increases_base_metal_capacity");
            entity.Property(e => e.IncreasesBaseShieldCreatingSomethingPercentage).HasColumnName("increases_base_shield_creating_something_percentage");
            entity.Property(e => e.IncreasesBaseShieldPercentage).HasColumnName("increases_base_shield_percentage");
            entity.Property(e => e.IncreasesBaseShieldPoints).HasColumnName("increases_base_shield_points");
            entity.Property(e => e.IncreasesColonizableBasessPoint).HasColumnName("increases_colonizable_basess_point");
            entity.Property(e => e.IncreasesCrystalSafeDeposit).HasColumnName("increases_crystal_safe_deposit");
            entity.Property(e => e.IncreasesCrystalSafeDepositPercentage).HasColumnName("increases_crystal_safe_deposit_percentage");
            entity.Property(e => e.IncreasesDarkMatterProductionOnDominationExpMultiplier).HasColumnName("increases_dark_matter_production_on_domination_exp_multiplier");
            entity.Property(e => e.IncreasesDarkMatterSafeDeposit).HasColumnName("increases_dark_matter_safe_deposit");
            entity.Property(e => e.IncreasesDarkMatterSafeDepositPercentage).HasColumnName("increases_dark_matter_safe_deposit_percentage");
            entity.Property(e => e.IncreasesDefenseToAllDefensesPercentage).HasColumnName("increases_defense_to_all_defenses_percentage");
            entity.Property(e => e.IncreasesDefenseToAllShipsPercentage).HasColumnName("increases_defense_to_all_ships_percentage");
            entity.Property(e => e.IncreasesDeuteriumProductionOnDominationExpMultiplier).HasColumnName("increases_deuterium_production_on_domination_exp_multiplier");
            entity.Property(e => e.IncreasesDeuteriumSafeDeposit).HasColumnName("increases_deuterium_safe_deposit");
            entity.Property(e => e.IncreasesDeuteriumSafeDepositPercentage).HasColumnName("increases_deuterium_safe_deposit_percentage");
            entity.Property(e => e.IncreasesExpeditionRewardPercentage).HasColumnName("increases_expedition_reward_percentage");
            entity.Property(e => e.IncreasesFleetTravelWhenMinerShipsFullFleetPercentage).HasColumnName("increases_fleet_travel_when_miner_ships_full_fleet_percentage");
            entity.Property(e => e.IncreasesMaterialProductionOnExpeditionsPercentage).HasColumnName("increases_material_production_on_expeditions_percentage");
            entity.Property(e => e.IncreasesMetalFuselageOnDominationExpeditionsPercentage).HasColumnName("increases_metal_fuselage_on_domination_expeditions_percentage");
            entity.Property(e => e.IncreasesMetalSafeDeposit).HasColumnName("increases_metal_safe_deposit");
            entity.Property(e => e.IncreasesMetalSafeDepositPercentage).HasColumnName("increases_metal_safe_deposit_percentage");
            entity.Property(e => e.IncreasesMinersShipCargoPercentage).HasColumnName("increases_miners_ship_cargo_percentage");
            entity.Property(e => e.IncreasesMinesMaterialProductionPercentage).HasColumnName("increases_mines_material_production_percentage");
            entity.Property(e => e.IncreasesPureGdMinerPercentage).HasColumnName("increases_pure_gd_miner_percentage");
            entity.Property(e => e.IncreasesSafeExtractionPercentage).HasColumnName("increases_safe_extraction_percentage");
            entity.Property(e => e.IncreasesShieldToAllBasesPercentage).HasColumnName("increases_shield_to_all_bases_percentage");
            entity.Property(e => e.IncreasesShieldToAllShipsPercentage).HasColumnName("increases_shield_to_all_ships_percentage");
            entity.Property(e => e.IncreasesSpectralFuselageOnDominationExpPercentage).HasColumnName("increases_spectral_fuselage_on_domination_exp_percentage");
            entity.Property(e => e.IncreasesTechnologyCreationTimePercentage).HasColumnName("increases_technology_creation_time_percentage");
            entity.Property(e => e.IncreasesTotalDamageForMetallicFuselageShipsPercentage).HasColumnName("increases_total_damage_for_metallic_fuselage_ships_percentage");
            entity.Property(e => e.IncreasesTotalDamageForSpectralFuselageShipsPercentage).HasColumnName("increases_total_damage_for_spectral_fuselage_ships_percentage");
            entity.Property(e => e.IncreasesTotalDefenseForMetallicFuselageShipsPercentage).HasColumnName("increases_total_defense_for_metallic_fuselage_ships_percentage");
            entity.Property(e => e.IncreasesTotalDefenseForSpectralFuselageShipsPercentage).HasColumnName("increases_total_defense_for_spectral_fuselage_ships_percentage");
            entity.Property(e => e.InstantBuildingCreationPercentage).HasColumnName("instant_building_creation_percentage");
            entity.Property(e => e.InstantShipCreationPercentage).HasColumnName("instant_ship_creation_percentage");
            entity.Property(e => e.InstantShipUpgradePercentage).HasColumnName("instant_ship_upgrade_percentage");
            entity.Property(e => e.InstantStructureUpgradePercentage).HasColumnName("instant_structure_upgrade_percentage");
            entity.Property(e => e.InstantTechnologyCreationPercentage).HasColumnName("instant_technology_creation_percentage");
            entity.Property(e => e.InstantTechnologyUpgradePercentage).HasColumnName("instant_technology_upgrade_percentage");
            entity.Property(e => e.InstantTravelPercentage).HasColumnName("instant_travel_percentage");
            entity.Property(e => e.IonicAttackPercentage).HasColumnName("ionic_attack_percentage");
            entity.Property(e => e.IonicAttackPoints).HasColumnName("ionic_attack_points");
            entity.Property(e => e.IonicDefensePercentage).HasColumnName("ionic_defense_percentage");
            entity.Property(e => e.IonicDefensePoints).HasColumnName("ionic_defense_points");
            entity.Property(e => e.KineticAttackPercentage).HasColumnName("kinetic_attack_percentage");
            entity.Property(e => e.KineticAttackPoints).HasColumnName("kinetic_attack_points");
            entity.Property(e => e.KineticDefensePercentage).HasColumnName("kinetic_defense_percentage");
            entity.Property(e => e.KineticDefensePoints).HasColumnName("kinetic_defense_points");
            entity.Property(e => e.LaserAttackPercentage).HasColumnName("laser_attack_percentage");
            entity.Property(e => e.LaserAttackPoints).HasColumnName("laser_attack_points");
            entity.Property(e => e.LaserDefensePercentage).HasColumnName("laser_defense_percentage");
            entity.Property(e => e.LaserDefensePoints).HasColumnName("laser_defense_points");
            entity.Property(e => e.MetalProduction).HasColumnName("metal_production");
            entity.Property(e => e.MetalProductionBoostPercentage).HasColumnName("metal_production_boost_percentage");
            entity.Property(e => e.MetalProductionPercentage).HasColumnName("metal_production_percentage");
            entity.Property(e => e.MirrorDamagePercentage).HasColumnName("mirror_damage_percentage");
            entity.Property(e => e.MirrorDamagePoints).HasColumnName("mirror_damage_points");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.NeoTransmuter).HasColumnName("neo_transmuter");
            entity.Property(e => e.NoDamagePvp).HasColumnName("no_damage_pvp");
            entity.Property(e => e.NotConsumeBlueprintUsePercentage).HasColumnName("not_consume_blueprint_use_percentage");
            entity.Property(e => e.NotConsumeResourcesBuildingStructuresPercentage).HasColumnName("not_consume_resources_building_structures_percentage");
            entity.Property(e => e.NotConsumeResourcesCreatingTechnologiesPercentage).HasColumnName("not_consume_resources_creating_technologies_percentage");
            entity.Property(e => e.NovaDefensePercentage).HasColumnName("nova_defense_percentage");
            entity.Property(e => e.PhantomCoinProduction).HasColumnName("phantom_coin_production");
            entity.Property(e => e.PhantomCoinProductionPercentage).HasColumnName("phantom_coin_production_percentage");
            entity.Property(e => e.PlasmaAttackPercentage).HasColumnName("plasma_attack_percentage");
            entity.Property(e => e.PlasmaAttackPoints).HasColumnName("plasma_attack_points");
            entity.Property(e => e.PlasmaDefensePercentage).HasColumnName("plasma_defense_percentage");
            entity.Property(e => e.PlasmaDefensePoints).HasColumnName("plasma_defense_points");
            entity.Property(e => e.PreventDamagePercentage).HasColumnName("prevent_damage_percentage");
            entity.Property(e => e.PreventDamagePoints).HasColumnName("prevent_damage_points");
            entity.Property(e => e.RandomTechnologyCreationUsingBlueprintPercentage).HasColumnName("random_technology_creation_using_blueprint_percentage");
            entity.Property(e => e.Recycler).HasColumnName("recycler");
            entity.Property(e => e.ReduceAstrobotsCreationCostsPercentage).HasColumnName("reduce_astrobots_creation_costs_percentage");
            entity.Property(e => e.ReduceAstrobotsRepairCostsPercentage).HasColumnName("reduce_astrobots_repair_costs_percentage");
            entity.Property(e => e.ReduceBuildingUpgradingCostPercentage).HasColumnName("reduce_building_upgrading_cost_percentage");
            entity.Property(e => e.ReduceBuildingUpgradingTimePercentage).HasColumnName("reduce_building_upgrading_time_percentage");
            entity.Property(e => e.ReduceBurningCostPercentage).HasColumnName("reduce_burning_cost_percentage");
            entity.Property(e => e.ReduceCreationCostPercentage).HasColumnName("reduce_creation_cost_percentage");
            entity.Property(e => e.ReduceCreationTime).HasColumnName("reduce_creation_time");
            entity.Property(e => e.ReduceCreationTimePercentage).HasColumnName("reduce_creation_time_percentage");
            entity.Property(e => e.ReduceEnergyConsumptionPercentage).HasColumnName("reduce_energy_consumption_percentage");
            entity.Property(e => e.ReduceExpeditionTravelCostPercentage).HasColumnName("reduce_expedition_travel_cost_percentage");
            entity.Property(e => e.ReduceExpeditionTravelTimePercentage).HasColumnName("reduce_expedition_travel_time_percentage");
            entity.Property(e => e.ReduceExpeditionTravelTimeSeconds).HasColumnName("reduce_expedition_travel_time_seconds");
            entity.Property(e => e.ReduceExplorationDamageProbabilityPercentage).HasColumnName("reduce_exploration_damage_probability_percentage");
            entity.Property(e => e.ReduceFleetTravelingCostsPercentage).HasColumnName("reduce_fleet_traveling_costs_percentage");
            entity.Property(e => e.ReduceLostSectorExpeditionDeuteriumAndGdCostPercentage).HasColumnName("reduce_lost_sector_expedition_deuterium_and_gd_cost_percentage");
            entity.Property(e => e.ReduceRepairCostsPercentage).HasColumnName("reduce_repair_costs_percentage");
            entity.Property(e => e.ReduceResourcesCostToLevelUpStructuresPercentage).HasColumnName("reduce_resources_cost_to_level_up_structures_percentage");
            entity.Property(e => e.ReduceResourcesCostToLevelUpTechnologiesPercentage).HasColumnName("reduce_resources_cost_to_level_up_technologies_percentage");
            entity.Property(e => e.ReduceShipCreationCostPercentage).HasColumnName("reduce_ship_creation_cost_percentage");
            entity.Property(e => e.ReduceShipCreationTimePercentage).HasColumnName("reduce_ship_creation_time_percentage");
            entity.Property(e => e.ReduceTechCreationCost).HasColumnName("reduce_tech_creation_cost");
            entity.Property(e => e.ReduceTechCreationCostPercentage).HasColumnName("reduce_tech_creation_cost_percentage");
            entity.Property(e => e.ReduceTechCreationTime).HasColumnName("reduce_tech_creation_time");
            entity.Property(e => e.ReduceTechCreationTimePercentage).HasColumnName("reduce_tech_creation_time_percentage");
            entity.Property(e => e.ReduceTimeToLevelUpStructuresPercentage).HasColumnName("reduce_time_to_level_up_structures_percentage");
            entity.Property(e => e.ReduceTimeToLevelUpTechnologiesPercentage).HasColumnName("reduce_time_to_level_up_technologies_percentage");
            entity.Property(e => e.ReduceTransportCostPercentage).HasColumnName("reduce_transport_cost_percentage");
            entity.Property(e => e.ReduceTransportTimePercentage).HasColumnName("reduce_transport_time_percentage");
            entity.Property(e => e.ResourceProduction).HasColumnName("resource_production");
            entity.Property(e => e.ResourceProductionPercentage).HasColumnName("resource_production_percentage");
            entity.Property(e => e.SasoriExplorationSpyTech).HasColumnName("sasori_exploration_spy_tech");
            entity.Property(e => e.SasoriInsuranceOne).HasColumnName("sasori_insurance_one");
            entity.Property(e => e.SkillTypeId).HasColumnName("skill_type_id");
            entity.Property(e => e.Stack).HasColumnName("stack");
            entity.Property(e => e.Terraformer).HasColumnName("terraformer");
            entity.Property(e => e.TotalDamagePercentage).HasColumnName("total_damage_percentage");
            entity.Property(e => e.TotalDamagePoints).HasColumnName("total_damage_points");
            entity.Property(e => e.TotalDefensePercentage).HasColumnName("total_defense_percentage");
            entity.Property(e => e.TotalDefensePoints).HasColumnName("total_defense_points");
            entity.Property(e => e.TransportSpeedPercentage).HasColumnName("transport_speed_percentage");
            entity.Property(e => e.TransportSpeedPoints).HasColumnName("transport_speed_points");
            entity.Property(e => e.TransportationCapacityPercentage).HasColumnName("transportation_capacity_percentage");
            entity.Property(e => e.TransportationCapacityPoints).HasColumnName("transportation_capacity_points");
            entity.Property(e => e.TransportationFleetSpacePercentage).HasColumnName("transportation_fleet_space_percentage");
            entity.Property(e => e.TransportationFleetSpacePoints).HasColumnName("transportation_fleet_space_points");
            entity.Property(e => e.TransportationShipsDefensePercentage).HasColumnName("transportation_ships_defense_percentage");
            entity.Property(e => e.TransportationShipsDefensePoints).HasColumnName("transportation_ships_defense_points");
            entity.Property(e => e.TransportationSpaceShipCargoPercentage).HasColumnName("transportation_space_ship_cargo_percentage");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.Xmas23Recycler).HasColumnName("xmas_23_recycler");

            entity.HasOne(d => d.SkillType).WithMany(p => p.GalaxyDustApiSkillstats)
                .HasForeignKey(d => d.SkillTypeId)
                .HasConstraintName("galaxy_dust_api_skil_skill_type_id_b0d1b5fe_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiSkilltype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_skilltype_pkey");

            entity.ToTable("galaxy_dust_api_skilltype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiStar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_star_pkey");

            entity.ToTable("galaxy_dust_api_star");

            entity.HasIndex(e => e.ColorTypeId, "galaxy_dust_api_star_color_type_id_1c826ad3");

            entity.HasIndex(e => e.FirstDiscovererId, "galaxy_dust_api_star_first_discoverer_id_b8b197b3");

            entity.HasIndex(e => e.SecondDiscovererId, "galaxy_dust_api_star_second_discoverer_id_3dff6c66");

            entity.HasIndex(e => e.StarClusterId, "galaxy_dust_api_star_star_cluster_id_c08aed9a");

            entity.HasIndex(e => e.StarStatId, "galaxy_dust_api_star_star_stat_id_ba0200e9");

            entity.HasIndex(e => e.StelarBodyId, "galaxy_dust_api_star_stelar_body_id_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Atmosphere).HasColumnName("atmosphere");
            entity.Property(e => e.Circunference).HasColumnName("circunference");
            entity.Property(e => e.ColorTypeId).HasColumnName("color_type_id");
            entity.Property(e => e.Coords)
                .HasMaxLength(255)
                .HasColumnName("coords");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.DiscoveredDate).HasColumnName("discovered_date");
            entity.Property(e => e.FirstDiscovererId).HasColumnName("first_discoverer_id");
            entity.Property(e => e.Gravity).HasColumnName("gravity");
            entity.Property(e => e.Mass).HasColumnName("mass");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.NumberOfPlanets).HasColumnName("number_of_planets");
            entity.Property(e => e.OrbitTime).HasColumnName("orbit_time");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.Radiation).HasColumnName("radiation");
            entity.Property(e => e.SecondDiscovererId).HasColumnName("second_discoverer_id");
            entity.Property(e => e.Size).HasColumnName("size");
            entity.Property(e => e.StarClusterId).HasColumnName("star_cluster_id");
            entity.Property(e => e.StarDiscoverProbabilityRateMax).HasColumnName("star_discover_probability_rate_max");
            entity.Property(e => e.StarDiscoverProbabilityRateMin).HasColumnName("star_discover_probability_rate_min");
            entity.Property(e => e.StarStatId).HasColumnName("star_stat_id");
            entity.Property(e => e.StelarBodyId).HasColumnName("stelar_body_id");
            entity.Property(e => e.Temperature).HasColumnName("temperature");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.ColorType).WithMany(p => p.GalaxyDustApiStars)
                .HasForeignKey(d => d.ColorTypeId)
                .HasConstraintName("galaxy_dust_api_star_color_type_id_1c826ad3_fk_galaxy_du");

            entity.HasOne(d => d.FirstDiscoverer).WithMany(p => p.GalaxyDustApiStarFirstDiscoverers)
                .HasForeignKey(d => d.FirstDiscovererId)
                .HasConstraintName("galaxy_dust_api_star_first_discoverer_id_b8b197b3_fk_galaxy_du");

            entity.HasOne(d => d.SecondDiscoverer).WithMany(p => p.GalaxyDustApiStarSecondDiscoverers)
                .HasForeignKey(d => d.SecondDiscovererId)
                .HasConstraintName("galaxy_dust_api_star_second_discoverer_id_3dff6c66_fk_galaxy_du");

            entity.HasOne(d => d.StarCluster).WithMany(p => p.GalaxyDustApiStars)
                .HasForeignKey(d => d.StarClusterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_star_star_cluster_id_c08aed9a_fk_galaxy_du");

            entity.HasOne(d => d.StarStat).WithMany(p => p.GalaxyDustApiStars)
                .HasForeignKey(d => d.StarStatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_star_star_stat_id_ba0200e9_fk_galaxy_du");

            entity.HasOne(d => d.StelarBody).WithOne(p => p.GalaxyDustApiStar)
                .HasForeignKey<GalaxyDustApiStar>(d => d.StelarBodyId)
                .HasConstraintName("galaxy_dust_api_star_stelar_body_id_d544471d_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiStarcluster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_starcluster_pkey");

            entity.ToTable("galaxy_dust_api_starcluster");

            entity.HasIndex(e => e.GalaxyId, "galaxy_dust_api_starcluster_galaxy_id_15490127");

            entity.HasIndex(e => e.StelarBodyId, "galaxy_dust_api_starcluster_stelar_body_id_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Coords)
                .HasMaxLength(255)
                .HasColumnName("coords");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.GalaxyId).HasColumnName("galaxy_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.NumberOfStars).HasColumnName("number_of_stars");
            entity.Property(e => e.StarDiscoverProbabilityRateMax).HasColumnName("star_discover_probability_rate_max");
            entity.Property(e => e.StarDiscoverProbabilityRateMin).HasColumnName("star_discover_probability_rate_min");
            entity.Property(e => e.StelarBodyId).HasColumnName("stelar_body_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Galaxy).WithMany(p => p.GalaxyDustApiStarclusters)
                .HasForeignKey(d => d.GalaxyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_star_galaxy_id_15490127_fk_galaxy_du");

            entity.HasOne(d => d.StelarBody).WithOne(p => p.GalaxyDustApiStarcluster)
                .HasForeignKey<GalaxyDustApiStarcluster>(d => d.StelarBodyId)
                .HasConstraintName("galaxy_dust_api_star_stelar_body_id_c5a4c3ee_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiStarstat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_starstat_pkey");

            entity.ToTable("galaxy_dust_api_starstat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AtmosphereMax).HasColumnName("atmosphere_max");
            entity.Property(e => e.AtmosphereMin).HasColumnName("atmosphere_min");
            entity.Property(e => e.CircunferenceMax).HasColumnName("circunference_max");
            entity.Property(e => e.CircunferenceMin).HasColumnName("circunference_min");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.GravityMax).HasColumnName("gravity_max");
            entity.Property(e => e.GravityMin).HasColumnName("gravity_min");
            entity.Property(e => e.MassMax).HasColumnName("mass_max");
            entity.Property(e => e.MassMin).HasColumnName("mass_min");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.OrbitTimeMax).HasColumnName("orbit_time_max");
            entity.Property(e => e.OrbitTimeMin).HasColumnName("orbit_time_min");
            entity.Property(e => e.RadiationMax).HasColumnName("radiation_max");
            entity.Property(e => e.RadiationMin).HasColumnName("radiation_min");
            entity.Property(e => e.SizeRateMax).HasColumnName("size_rate_max");
            entity.Property(e => e.SizeRateMin).HasColumnName("size_rate_min");
            entity.Property(e => e.TemperatureMax).HasColumnName("temperature_max");
            entity.Property(e => e.TemperatureMin).HasColumnName("temperature_min");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<GalaxyDustApiStelarbody>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_stelarbody_pkey");

            entity.ToTable("galaxy_dust_api_stelarbody");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<GalaxyDustApiStructurecategorylevelrequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_structurecategorylevelrequirement_pkey");

            entity.ToTable("galaxy_dust_api_structurecategorylevelrequirement");

            entity.HasIndex(e => e.ItemCategoryId, "galaxy_dust_api_structurec_item_category_id_600965b4");

            entity.HasIndex(e => e.StructureLevelUpRequirementId, "galaxy_dust_api_structurec_structure_level_up_require_8ff9f7f1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemCategoryId).HasColumnName("item_category_id");
            entity.Property(e => e.LevelRequired).HasColumnName("level_required");
            entity.Property(e => e.StructureLevelUpRequirementId).HasColumnName("structure_level_up_requirement_id");

            entity.HasOne(d => d.ItemCategory).WithMany(p => p.GalaxyDustApiStructurecategorylevelrequirements)
                .HasForeignKey(d => d.ItemCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_stru_item_category_id_600965b4_fk_galaxy_du");

            entity.HasOne(d => d.StructureLevelUpRequirement).WithMany(p => p.GalaxyDustApiStructurecategorylevelrequirements)
                .HasForeignKey(d => d.StructureLevelUpRequirementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_stru_structure_level_up_r_8ff9f7f1_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiStructureleveluprequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_structureleveluprequirement_pkey");

            entity.ToTable("galaxy_dust_api_structureleveluprequirement");

            entity.HasIndex(e => e.StructureId, "galaxy_dust_api_structurel_structure_id_2856c4d8");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LevelToEvolve).HasColumnName("level_to_evolve");
            entity.Property(e => e.LevelUpDuration).HasColumnName("level_up_duration");
            entity.Property(e => e.StructureId).HasColumnName("structure_id");

            entity.HasOne(d => d.Structure).WithMany(p => p.GalaxyDustApiStructureleveluprequirements)
                .HasForeignKey(d => d.StructureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_stru_structure_id_2856c4d8_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiStructureskilllevelgroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_structureskilllevelgroup_pkey");

            entity.ToTable("galaxy_dust_api_structureskilllevelgroup");

            entity.HasIndex(e => e.SkillId, "galaxy_dust_api_structureskilllevelgroup_skill_id_9f6a0821");

            entity.HasIndex(e => e.StructureId, "galaxy_dust_api_structureskilllevelgroup_structure_id_4d94ee2d");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BlockGroup).HasColumnName("block_group");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.SkillId).HasColumnName("skill_id");
            entity.Property(e => e.StructureId).HasColumnName("structure_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Skill).WithMany(p => p.GalaxyDustApiStructureskilllevelgroups)
                .HasForeignKey(d => d.SkillId)
                .HasConstraintName("galaxy_dust_api_stru_skill_id_9f6a0821_fk_galaxy_du");

            entity.HasOne(d => d.Structure).WithMany(p => p.GalaxyDustApiStructureskilllevelgroups)
                .HasForeignKey(d => d.StructureId)
                .HasConstraintName("galaxy_dust_api_stru_structure_id_4d94ee2d_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiStructurestat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_structurestat_pkey");

            entity.ToTable("galaxy_dust_api_structurestat");

            entity.HasIndex(e => e.CollectionId, "galaxy_dust_api_structurestat_collection_id_f86dbedf");

            entity.HasIndex(e => e.CompanyId, "galaxy_dust_api_structurestat_company_id_4eb954ed");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_structurestat_item_id_key").IsUnique();

            entity.HasIndex(e => e.RarityId, "galaxy_dust_api_structurestat_rarity_id_d33d42c0");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CollectionId).HasColumnName("collection_id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.FileDirection)
                .HasMaxLength(200)
                .HasColumnName("file_direction");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.MaxLevel).HasColumnName("max_level");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.PowerScore).HasColumnName("power_score");
            entity.Property(e => e.RarityId).HasColumnName("rarity_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Collection).WithMany(p => p.GalaxyDustApiStructurestats)
                .HasForeignKey(d => d.CollectionId)
                .HasConstraintName("galaxy_dust_api_stru_collection_id_f86dbedf_fk_galaxy_du");

            entity.HasOne(d => d.Company).WithMany(p => p.GalaxyDustApiStructurestats)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("galaxy_dust_api_stru_company_id_4eb954ed_fk_galaxy_du");

            entity.HasOne(d => d.Item).WithOne(p => p.GalaxyDustApiStructurestat)
                .HasForeignKey<GalaxyDustApiStructurestat>(d => d.ItemId)
                .HasConstraintName("galaxy_dust_api_stru_item_id_4f3edfd7_fk_galaxy_du");

            entity.HasOne(d => d.Rarity).WithMany(p => p.GalaxyDustApiStructurestats)
                .HasForeignKey(d => d.RarityId)
                .HasConstraintName("galaxy_dust_api_stru_rarity_id_d33d42c0_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiStructuretype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_structuretype_pkey");

            entity.ToTable("galaxy_dust_api_structuretype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiStructuretypegroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_structuretypegroup_pkey");

            entity.ToTable("galaxy_dust_api_structuretypegroup");

            entity.HasIndex(e => e.StructureId, "galaxy_dust_api_structuretypegroup_structure_id_8fcc1a92");

            entity.HasIndex(e => e.StructureTypeId, "galaxy_dust_api_structuretypegroup_structure_type_id_6c696444");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.StructureId).HasColumnName("structure_id");
            entity.Property(e => e.StructureTypeId).HasColumnName("structure_type_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Structure).WithMany(p => p.GalaxyDustApiStructuretypegroups)
                .HasForeignKey(d => d.StructureId)
                .HasConstraintName("galaxy_dust_api_stru_structure_id_8fcc1a92_fk_galaxy_du");

            entity.HasOne(d => d.StructureType).WithMany(p => p.GalaxyDustApiStructuretypegroups)
                .HasForeignKey(d => d.StructureTypeId)
                .HasConstraintName("galaxy_dust_api_stru_structure_type_id_6c696444_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiTechnologycategorylevelrequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_technologycategorylevelrequirement_pkey");

            entity.ToTable("galaxy_dust_api_technologycategorylevelrequirement");

            entity.HasIndex(e => e.ItemCategoryId, "galaxy_dust_api_technology_item_category_id_7ddd4e56");

            entity.HasIndex(e => e.TechnologyLevelUpRequirementId, "galaxy_dust_api_technology_technology_level_up_requir_5062e401");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemCategoryId).HasColumnName("item_category_id");
            entity.Property(e => e.LevelRequired).HasColumnName("level_required");
            entity.Property(e => e.TechnologyLevelUpRequirementId).HasColumnName("technology_level_up_requirement_id");

            entity.HasOne(d => d.ItemCategory).WithMany(p => p.GalaxyDustApiTechnologycategorylevelrequirements)
                .HasForeignKey(d => d.ItemCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_tech_item_category_id_7ddd4e56_fk_galaxy_du");

            entity.HasOne(d => d.TechnologyLevelUpRequirement).WithMany(p => p.GalaxyDustApiTechnologycategorylevelrequirements)
                .HasForeignKey(d => d.TechnologyLevelUpRequirementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_tech_technology_level_up__5062e401_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiTechnologyleveluprequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_technologyleveluprequirement_pkey");

            entity.ToTable("galaxy_dust_api_technologyleveluprequirement");

            entity.HasIndex(e => e.TechnologyId, "galaxy_dust_api_technology_technology_id_17a8510d");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LevelToEvolve).HasColumnName("level_to_evolve");
            entity.Property(e => e.LevelUpDuration).HasColumnName("level_up_duration");
            entity.Property(e => e.TechnologyId).HasColumnName("technology_id");

            entity.HasOne(d => d.Technology).WithMany(p => p.GalaxyDustApiTechnologyleveluprequirements)
                .HasForeignKey(d => d.TechnologyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_tech_technology_id_17a8510d_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiTechnologyskilllevelgroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_technologyskilllevelgroup_pkey");

            entity.ToTable("galaxy_dust_api_technologyskilllevelgroup");

            entity.HasIndex(e => e.TechnologyId, "galaxy_dust_api_technology_technology_id_dcb9f028");

            entity.HasIndex(e => e.SkillId, "galaxy_dust_api_technologyskilllevelgroup_skill_id_8349712f");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BlockGroup).HasColumnName("block_group");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.SkillId).HasColumnName("skill_id");
            entity.Property(e => e.TechnologyId).HasColumnName("technology_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Skill).WithMany(p => p.GalaxyDustApiTechnologyskilllevelgroups)
                .HasForeignKey(d => d.SkillId)
                .HasConstraintName("galaxy_dust_api_tech_skill_id_8349712f_fk_galaxy_du");

            entity.HasOne(d => d.Technology).WithMany(p => p.GalaxyDustApiTechnologyskilllevelgroups)
                .HasForeignKey(d => d.TechnologyId)
                .HasConstraintName("galaxy_dust_api_tech_technology_id_dcb9f028_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiTechnologystat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_technologystat_pkey");

            entity.ToTable("galaxy_dust_api_technologystat");

            entity.HasIndex(e => e.CollectionId, "galaxy_dust_api_technologystat_collection_id_2982101c");

            entity.HasIndex(e => e.CompanyId, "galaxy_dust_api_technologystat_company_id_9cf38a51");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_technologystat_item_id_key").IsUnique();

            entity.HasIndex(e => e.RarityId, "galaxy_dust_api_technologystat_rarity_id_9d60c3d8");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CollectionId).HasColumnName("collection_id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.FileDirection)
                .HasMaxLength(200)
                .HasColumnName("file_direction");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.MaxLevel).HasColumnName("max_level");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.PowerScore).HasColumnName("power_score");
            entity.Property(e => e.RarityId).HasColumnName("rarity_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Collection).WithMany(p => p.GalaxyDustApiTechnologystats)
                .HasForeignKey(d => d.CollectionId)
                .HasConstraintName("galaxy_dust_api_tech_collection_id_2982101c_fk_galaxy_du");

            entity.HasOne(d => d.Company).WithMany(p => p.GalaxyDustApiTechnologystats)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("galaxy_dust_api_tech_company_id_9cf38a51_fk_galaxy_du");

            entity.HasOne(d => d.Item).WithOne(p => p.GalaxyDustApiTechnologystat)
                .HasForeignKey<GalaxyDustApiTechnologystat>(d => d.ItemId)
                .HasConstraintName("galaxy_dust_api_tech_item_id_2f581c02_fk_galaxy_du");

            entity.HasOne(d => d.Rarity).WithMany(p => p.GalaxyDustApiTechnologystats)
                .HasForeignKey(d => d.RarityId)
                .HasConstraintName("galaxy_dust_api_tech_rarity_id_9d60c3d8_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiTechnologytype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_technologytype_pkey");

            entity.ToTable("galaxy_dust_api_technologytype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiTechnologytypegroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_technologytypegroup_pkey");

            entity.ToTable("galaxy_dust_api_technologytypegroup");

            entity.HasIndex(e => e.TechnologyId, "galaxy_dust_api_technologytypegroup_technology_id_44854a22");

            entity.HasIndex(e => e.TechnologyTypeId, "galaxy_dust_api_technologytypegroup_technology_type_id_35836569");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.TechnologyId).HasColumnName("technology_id");
            entity.Property(e => e.TechnologyTypeId).HasColumnName("technology_type_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Technology).WithMany(p => p.GalaxyDustApiTechnologytypegroups)
                .HasForeignKey(d => d.TechnologyId)
                .HasConstraintName("galaxy_dust_api_tech_technology_id_44854a22_fk_galaxy_du");

            entity.HasOne(d => d.TechnologyType).WithMany(p => p.GalaxyDustApiTechnologytypegroups)
                .HasForeignKey(d => d.TechnologyTypeId)
                .HasConstraintName("galaxy_dust_api_tech_technology_type_id_35836569_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiTicketstat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_ticketstat_pkey");

            entity.ToTable("galaxy_dust_api_ticketstat");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_ticketstat_item_id_key").IsUnique();

            entity.HasIndex(e => e.RarityId, "galaxy_dust_api_ticketstat_rarity_id_96199e73");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.FileDirection)
                .HasMaxLength(200)
                .HasColumnName("file_direction");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.RarityId).HasColumnName("rarity_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Item).WithOne(p => p.GalaxyDustApiTicketstat)
                .HasForeignKey<GalaxyDustApiTicketstat>(d => d.ItemId)
                .HasConstraintName("galaxy_dust_api_tick_item_id_02a81a9f_fk_galaxy_du");

            entity.HasOne(d => d.Rarity).WithMany(p => p.GalaxyDustApiTicketstats)
                .HasForeignKey(d => d.RarityId)
                .HasConstraintName("galaxy_dust_api_tick_rarity_id_96199e73_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiTickettype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_tickettype_pkey");

            entity.ToTable("galaxy_dust_api_tickettype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiTickettypegroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_tickettypegroup_pkey");

            entity.ToTable("galaxy_dust_api_tickettypegroup");

            entity.HasIndex(e => e.TicketId, "galaxy_dust_api_tickettypegroup_ticket_id_b382d2e7");

            entity.HasIndex(e => e.TicketTypeId, "galaxy_dust_api_tickettypegroup_ticket_type_id_0156bf00");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.TicketId).HasColumnName("ticket_id");
            entity.Property(e => e.TicketTypeId).HasColumnName("ticket_type_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Ticket).WithMany(p => p.GalaxyDustApiTickettypegroups)
                .HasForeignKey(d => d.TicketId)
                .HasConstraintName("galaxy_dust_api_tick_ticket_id_b382d2e7_fk_galaxy_du");

            entity.HasOne(d => d.TicketType).WithMany(p => p.GalaxyDustApiTickettypegroups)
                .HasForeignKey(d => d.TicketTypeId)
                .HasConstraintName("galaxy_dust_api_tick_ticket_type_id_0156bf00_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiToolcategorylevelrequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_toolcategorylevelrequirement_pkey");

            entity.ToTable("galaxy_dust_api_toolcategorylevelrequirement");

            entity.HasIndex(e => e.ItemCategoryId, "galaxy_dust_api_toolcatego_item_category_id_c9d8e30c");

            entity.HasIndex(e => e.ToolLevelUpRequirementId, "galaxy_dust_api_toolcatego_tool_level_up_requirement__6ea915ab");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemCategoryId).HasColumnName("item_category_id");
            entity.Property(e => e.LevelRequired).HasColumnName("level_required");
            entity.Property(e => e.ToolLevelUpRequirementId).HasColumnName("tool_level_up_requirement_id");

            entity.HasOne(d => d.ItemCategory).WithMany(p => p.GalaxyDustApiToolcategorylevelrequirements)
                .HasForeignKey(d => d.ItemCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_tool_item_category_id_c9d8e30c_fk_galaxy_du");

            entity.HasOne(d => d.ToolLevelUpRequirement).WithMany(p => p.GalaxyDustApiToolcategorylevelrequirements)
                .HasForeignKey(d => d.ToolLevelUpRequirementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_tool_tool_level_up_requir_6ea915ab_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiToolleveluprequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_toolleveluprequirement_pkey");

            entity.ToTable("galaxy_dust_api_toolleveluprequirement");

            entity.HasIndex(e => e.ToolId, "galaxy_dust_api_toolleveluprequirement_tool_id_9b1901c8");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LevelToEvolve).HasColumnName("level_to_evolve");
            entity.Property(e => e.LevelUpDuration).HasColumnName("level_up_duration");
            entity.Property(e => e.ToolId).HasColumnName("tool_id");

            entity.HasOne(d => d.Tool).WithMany(p => p.GalaxyDustApiToolleveluprequirements)
                .HasForeignKey(d => d.ToolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_tool_tool_id_9b1901c8_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiToolskilllevelgroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_toolskilllevelgroup_pkey");

            entity.ToTable("galaxy_dust_api_toolskilllevelgroup");

            entity.HasIndex(e => e.SkillId, "galaxy_dust_api_toolskilllevelgroup_skill_id_89fb2ebd");

            entity.HasIndex(e => e.ToolId, "galaxy_dust_api_toolskilllevelgroup_tool_id_138807c5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BlockGroup).HasColumnName("block_group");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.SkillId).HasColumnName("skill_id");
            entity.Property(e => e.ToolId).HasColumnName("tool_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Skill).WithMany(p => p.GalaxyDustApiToolskilllevelgroups)
                .HasForeignKey(d => d.SkillId)
                .HasConstraintName("galaxy_dust_api_tool_skill_id_89fb2ebd_fk_galaxy_du");

            entity.HasOne(d => d.Tool).WithMany(p => p.GalaxyDustApiToolskilllevelgroups)
                .HasForeignKey(d => d.ToolId)
                .HasConstraintName("galaxy_dust_api_tool_tool_id_138807c5_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiToolstat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_toolstat_pkey");

            entity.ToTable("galaxy_dust_api_toolstat");

            entity.HasIndex(e => e.CollectionId, "galaxy_dust_api_toolstat_collection_id_dbbe1b77");

            entity.HasIndex(e => e.CompanyId, "galaxy_dust_api_toolstat_company_id_a164cc62");

            entity.HasIndex(e => e.ItemId, "galaxy_dust_api_toolstat_item_id_key").IsUnique();

            entity.HasIndex(e => e.RarityId, "galaxy_dust_api_toolstat_rarity_id_5323b583");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CollectionId).HasColumnName("collection_id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Durability).HasColumnName("durability");
            entity.Property(e => e.FileDirection)
                .HasMaxLength(200)
                .HasColumnName("file_direction");
            entity.Property(e => e.FleetSpace).HasColumnName("fleet_space");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.MaxLevel).HasColumnName("max_level");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.PowerScore).HasColumnName("power_score");
            entity.Property(e => e.RarityId).HasColumnName("rarity_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Collection).WithMany(p => p.GalaxyDustApiToolstats)
                .HasForeignKey(d => d.CollectionId)
                .HasConstraintName("galaxy_dust_api_tool_collection_id_dbbe1b77_fk_galaxy_du");

            entity.HasOne(d => d.Company).WithMany(p => p.GalaxyDustApiToolstats)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("galaxy_dust_api_tool_company_id_a164cc62_fk_galaxy_du");

            entity.HasOne(d => d.Item).WithOne(p => p.GalaxyDustApiToolstat)
                .HasForeignKey<GalaxyDustApiToolstat>(d => d.ItemId)
                .HasConstraintName("galaxy_dust_api_tool_item_id_3141abeb_fk_galaxy_du");

            entity.HasOne(d => d.Rarity).WithMany(p => p.GalaxyDustApiToolstats)
                .HasForeignKey(d => d.RarityId)
                .HasConstraintName("galaxy_dust_api_tool_rarity_id_5323b583_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiTooltype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_tooltype_pkey");

            entity.ToTable("galaxy_dust_api_tooltype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GalaxyDustApiTooltypegroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_tooltypegroup_pkey");

            entity.ToTable("galaxy_dust_api_tooltypegroup");

            entity.HasIndex(e => e.ToolId, "galaxy_dust_api_tooltypegroup_tool_id_13c753dc");

            entity.HasIndex(e => e.ToolTypeId, "galaxy_dust_api_tooltypegroup_tool_type_id_43abae7d");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.ToolId).HasColumnName("tool_id");
            entity.Property(e => e.ToolTypeId).HasColumnName("tool_type_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Tool).WithMany(p => p.GalaxyDustApiTooltypegroups)
                .HasForeignKey(d => d.ToolId)
                .HasConstraintName("galaxy_dust_api_tool_tool_id_13c753dc_fk_galaxy_du");

            entity.HasOne(d => d.ToolType).WithMany(p => p.GalaxyDustApiTooltypegroups)
                .HasForeignKey(d => d.ToolTypeId)
                .HasConstraintName("galaxy_dust_api_tool_tool_type_id_43abae7d_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiTransportskill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_transportskill_pkey");

            entity.ToTable("galaxy_dust_api_transportskill");

            entity.HasIndex(e => e.SkillTypeId, "galaxy_dust_api_transportskill_skill_type_id_b8b86b44");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivationProbability).HasColumnName("activation_probability");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PocketTransportExpeditionExpansion).HasColumnName("pocket_transport_expedition_expansion");
            entity.Property(e => e.SafeFleetCarrierPercentage).HasColumnName("safe_fleet_carrier_percentage");
            entity.Property(e => e.SafeShipment).HasColumnName("safe_shipment");
            entity.Property(e => e.SkillTypeId).HasColumnName("skill_type_id");
            entity.Property(e => e.Stack).HasColumnName("stack");
            entity.Property(e => e.TransportFleetCapacityPercentage).HasColumnName("transport_fleet_capacity_percentage");
            entity.Property(e => e.TransportFleetCapacityPoints).HasColumnName("transport_fleet_capacity_points");
            entity.Property(e => e.TransportFullResistance).HasColumnName("transport_full_resistance");
            entity.Property(e => e.TransportInstantTravelPercentage).HasColumnName("transport_instant_travel_percentage");
            entity.Property(e => e.TransportSpeedPercentage).HasColumnName("transport_speed_percentage");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.SkillType).WithMany(p => p.GalaxyDustApiTransportskills)
                .HasForeignKey(d => d.SkillTypeId)
                .HasConstraintName("galaxy_dust_api_tran_skill_type_id_b8b86b44_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiTravel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_travel_pkey");

            entity.ToTable("galaxy_dust_api_travel");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_travel_account_id_69287ca8");

            entity.HasIndex(e => e.StelarBodyId, "galaxy_dust_api_travel_stelar_body_id_65bd0574");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.IsAutomatic).HasColumnName("is_automatic");
            entity.Property(e => e.IsMining).HasColumnName("is_mining");
            entity.Property(e => e.StarDiscovered).HasColumnName("star_discovered");
            entity.Property(e => e.StartTravelDate).HasColumnName("start_travel_date");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("status");
            entity.Property(e => e.StelarBodyId).HasColumnName("stelar_body_id");
            entity.Property(e => e.TimeToArriveInMinutes).HasColumnName("time_to_arrive_in_minutes");
            entity.Property(e => e.TimeToReturnInMinutes).HasColumnName("time_to_return_in_minutes");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiTravels)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_trav_account_id_69287ca8_fk_galaxy_du");

            entity.HasOne(d => d.StelarBody).WithMany(p => p.GalaxyDustApiTravels)
                .HasForeignKey(d => d.StelarBodyId)
                .HasConstraintName("galaxy_dust_api_trav_stelar_body_id_65bd0574_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiTraveldatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_traveldata_pkey");

            entity.ToTable("galaxy_dust_api_traveldata");

            entity.HasIndex(e => e.QmpToUseId, "galaxy_dust_api_traveldata_QMP_to_use_id_fb997d62");

            entity.HasIndex(e => e.AccountId, "galaxy_dust_api_traveldata_account_id_376ecbaa");

            entity.HasIndex(e => e.RepairKitToUseId, "galaxy_dust_api_traveldata_repair_kit_to_use_id_9dc0f539");

            entity.HasIndex(e => e.ToolToUseId, "galaxy_dust_api_traveldata_tool_to_use_id_6a8bf922");

            entity.HasIndex(e => e.TravelId, "galaxy_dust_api_traveldata_travel_id_2da20e4e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountAstrobots)
                .HasColumnType("character varying(500)[]")
                .HasColumnName("account_astrobots");
            entity.Property(e => e.AccountAstrobotsInGroups)
                .HasColumnType("character varying(500)[]")
                .HasColumnName("account_astrobots_in_groups");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AccountShips)
                .HasColumnType("character varying(500)[]")
                .HasColumnName("account_ships");
            entity.Property(e => e.AccountShipsInGroups)
                .HasColumnType("character varying(500)[]")
                .HasColumnName("account_ships_in_groups");
            entity.Property(e => e.Coords)
                .HasMaxLength(255)
                .HasColumnName("coords");
            entity.Property(e => e.FleetCargo).HasColumnName("fleet_cargo");
            entity.Property(e => e.FleetHealth).HasColumnName("fleet_health");
            entity.Property(e => e.FleetSpeed).HasColumnName("fleet_speed");
            entity.Property(e => e.Percentage).HasColumnName("percentage");
            entity.Property(e => e.QmpToUseId).HasColumnName("QMP_to_use_id");
            entity.Property(e => e.RepairKitToUseId).HasColumnName("repair_kit_to_use_id");
            entity.Property(e => e.StartTime).HasColumnName("start_time");
            entity.Property(e => e.Task)
                .HasColumnType("character varying")
                .HasColumnName("task");
            entity.Property(e => e.ToolToUseId).HasColumnName("tool_to_use_id");
            entity.Property(e => e.TotalTime).HasColumnName("total_time");
            entity.Property(e => e.TravelId).HasColumnName("travel_id");

            entity.HasOne(d => d.Account).WithMany(p => p.GalaxyDustApiTraveldata)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_trav_account_id_376ecbaa_fk_galaxy_du");

            entity.HasOne(d => d.QmpToUse).WithMany(p => p.GalaxyDustApiTraveldata)
                .HasForeignKey(d => d.QmpToUseId)
                .HasConstraintName("galaxy_dust_api_trav_QMP_to_use_id_fb997d62_fk_galaxy_du");

            entity.HasOne(d => d.RepairKitToUse).WithMany(p => p.GalaxyDustApiTraveldata)
                .HasForeignKey(d => d.RepairKitToUseId)
                .HasConstraintName("galaxy_dust_api_trav_repair_kit_to_use_id_9dc0f539_fk_galaxy_du");

            entity.HasOne(d => d.ToolToUse).WithMany(p => p.GalaxyDustApiTraveldata)
                .HasForeignKey(d => d.ToolToUseId)
                .HasConstraintName("galaxy_dust_api_trav_tool_to_use_id_6a8bf922_fk_galaxy_du");

            entity.HasOne(d => d.Travel).WithMany(p => p.GalaxyDustApiTraveldata)
                .HasForeignKey(d => d.TravelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_trav_travel_id_2da20e4e_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiXenogoncurrencyreward>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_xenogoncurrencyreward_pkey");

            entity.ToTable("galaxy_dust_api_xenogoncurrencyreward");

            entity.HasIndex(e => e.CurrencyId, "galaxy_dust_api_xenogoncurrencyreward_currency_id_14e38cbb");

            entity.HasIndex(e => e.XenogonEventId, "galaxy_dust_api_xenogoncurrencyreward_xenogon_event_id_6b1b5b81");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CurrencyAmount).HasColumnName("currency_amount");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.XenogonEventId).HasColumnName("xenogon_event_id");

            entity.HasOne(d => d.Currency).WithMany(p => p.GalaxyDustApiXenogoncurrencyrewards)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("galaxy_dust_api_xeno_currency_id_14e38cbb_fk_galaxy_du");

            entity.HasOne(d => d.XenogonEvent).WithMany(p => p.GalaxyDustApiXenogoncurrencyrewards)
                .HasForeignKey(d => d.XenogonEventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_xeno_xenogon_event_id_6b1b5b81_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiXenogonevent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_xenogonevent_pkey");

            entity.ToTable("galaxy_dust_api_xenogonevent");

            entity.HasIndex(e => e.FleetGroupNpcId, "galaxy_dust_api_xenogonevent_fleet_group_npc_id_26c14e74");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.FleetGroupNpcId).HasColumnName("fleet_group_npc_id");
            entity.Property(e => e.Level)
                .HasMaxLength(255)
                .HasColumnName("level");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.FleetGroupNpc).WithMany(p => p.GalaxyDustApiXenogonevents)
                .HasForeignKey(d => d.FleetGroupNpcId)
                .HasConstraintName("galaxy_dust_api_xeno_fleet_group_npc_id_26c14e74_fk_galaxy_du");
        });

        modelBuilder.Entity<GalaxyDustApiXenogonitemreward>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("galaxy_dust_api_xenogonitemreward_pkey");

            entity.ToTable("galaxy_dust_api_xenogonitemreward");

            entity.HasIndex(e => e.ItemToRewardId, "galaxy_dust_api_xenogonitemreward_item_to_reward_id_a6cc9826");

            entity.HasIndex(e => e.XenogonEventId, "galaxy_dust_api_xenogonitemreward_xenogon_event_id_e0dd6851");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemToRewardId).HasColumnName("item_to_reward_id");
            entity.Property(e => e.NumberOfItems).HasColumnName("number_of_items");
            entity.Property(e => e.XenogonEventId).HasColumnName("xenogon_event_id");

            entity.HasOne(d => d.ItemToReward).WithMany(p => p.GalaxyDustApiXenogonitemrewards)
                .HasForeignKey(d => d.ItemToRewardId)
                .HasConstraintName("galaxy_dust_api_xeno_item_to_reward_id_a6cc9826_fk_galaxy_du");

            entity.HasOne(d => d.XenogonEvent).WithMany(p => p.GalaxyDustApiXenogonitemrewards)
                .HasForeignKey(d => d.XenogonEventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("galaxy_dust_api_xeno_xenogon_event_id_e0dd6851_fk_galaxy_du");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
