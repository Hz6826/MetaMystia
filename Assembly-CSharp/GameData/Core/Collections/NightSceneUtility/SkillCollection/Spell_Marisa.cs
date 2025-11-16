using System;
using Common.CharacterUtility;
using GameData.Core.Collections.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.EventUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200026E RID: 622
	public class Spell_Marisa : SpellBase
	{
		// Token: 0x06004D80 RID: 19840 RVA: 0x001A9C50 File Offset: 0x001A7E50
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Marisa()
		{
			Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Marisa");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr);
			Spell_Marisa.NativeFieldInfoPtr_giveMushroomNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "giveMushroomNum");
			Spell_Marisa.NativeFieldInfoPtr_readyToFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "readyToFly");
			Spell_Marisa.NativeFieldInfoPtr_dashTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "dashTime");
			Spell_Marisa.NativeFieldInfoPtr_waitToEscape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "waitToEscape");
			Spell_Marisa.NativeFieldInfoPtr_whereToEscape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "whereToEscape");
			Spell_Marisa.NativeFieldInfoPtr_escapeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "escapeTime");
			Spell_Marisa.NativeFieldInfoPtr_stealThingNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "stealThingNum");
			Spell_Marisa.NativeFieldInfoPtr_mushroomStartSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "mushroomStartSpeed");
			Spell_Marisa.NativeFieldInfoPtr_mushroomStartToDash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "mushroomStartToDash");
			Spell_Marisa.NativeFieldInfoPtr_mushroomRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "mushroomRotate");
			Spell_Marisa.NativeFieldInfoPtr_mushroomAddSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "mushroomAddSpeed");
			Spell_Marisa.NativeFieldInfoPtr_mushroomEndSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "mushroomEndSpeed");
			Spell_Marisa.NativeFieldInfoPtr_cameraShakeAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "cameraShakeAmplitude");
			Spell_Marisa.NativeFieldInfoPtr_cameraShakeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "cameraShakeDuration");
			Spell_Marisa.NativeFieldInfoPtr_cameraShakeFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "cameraShakeFade");
			Spell_Marisa.NativeFieldInfoPtr_magicArrayEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "magicArrayEffect");
			Spell_Marisa.NativeFieldInfoPtr_magicExplosionEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "magicExplosionEffect");
			Spell_Marisa.NativeFieldInfoPtr_mushroomMilkyWay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "mushroomMilkyWay");
			Spell_Marisa.NativeFieldInfoPtr_magicArrayDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "magicArrayDuration");
			Spell_Marisa.NativeFieldInfoPtr_magicExplosionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "magicExplosionDuration");
			Spell_Marisa.NativeFieldInfoPtr_milkyWayDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "milkyWayDuration");
			Spell_Marisa.NativeFieldInfoPtr_milkyWayEffectsDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "milkyWayEffectsDuration");
			Spell_Marisa.NativeFieldInfoPtr_eyeEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "eyeEffect");
			Spell_Marisa.NativeFieldInfoPtr_punishmenPic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "punishmenPic");
			Spell_Marisa.NativeFieldInfoPtr_punishmentEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "punishmentEffect");
			Spell_Marisa.NativeFieldInfoPtr_stolenThing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "stolenThing");
			Spell_Marisa.NativeFieldInfoPtr_punishAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "punishAnim");
			Spell_Marisa.NativeFieldInfoPtr_punishmentPicDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "punishmentPicDuration");
			Spell_Marisa.NativeFieldInfoPtr_effectDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "effectDelay");
			Spell_Marisa.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, 100678913);
			Spell_Marisa.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, 100678914);
			Spell_Marisa.NativeMethodInfoPtr_MarisaStealImportantThings_Private_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, 100678915);
			Spell_Marisa.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, 100678916);
			Spell_Marisa.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, 100678917);
			Spell_Marisa.NativeMethodInfoPtr_Method_Internal_Static_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, 100678918);
		}

		// Token: 0x06004D81 RID: 19841 RVA: 0x001A9F3C File Offset: 0x001A813C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199241, XrefRangeEnd = 199243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Marisa.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004D82 RID: 19842 RVA: 0x001A9F80 File Offset: 0x001A8180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199243, XrefRangeEnd = 199249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Marisa.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004D83 RID: 19843 RVA: 0x001A9FDC File Offset: 0x001A81DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199283, RefRangeEnd = 199284, XrefRangeStart = 199249, XrefRangeEnd = 199283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprite MarisaStealImportantThings(int thingsType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref thingsType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa.NativeMethodInfoPtr_MarisaStealImportantThings_Private_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x06004D84 RID: 19844 RVA: 0x001AA028 File Offset: 0x001A8228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199284, XrefRangeEnd = 199290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Marisa.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004D85 RID: 19845 RVA: 0x001AA084 File Offset: 0x001A8284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199290, XrefRangeEnd = 199291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Marisa() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D86 RID: 19846 RVA: 0x001AA0C0 File Offset: 0x001A82C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 199294, RefRangeEnd = 199296, XrefRangeStart = 199291, XrefRangeEnd = 199294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Method_Internal_Static_Vector3_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa.NativeMethodInfoPtr_Method_Internal_Static_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004D87 RID: 19847 RVA: 0x0002856A File Offset: 0x0002676A
		public Spell_Marisa(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A2D RID: 6701
		// (get) Token: 0x06004D88 RID: 19848 RVA: 0x001AA0F0 File Offset: 0x001A82F0
		// (set) Token: 0x06004D89 RID: 19849 RVA: 0x00028573 File Offset: 0x00026773
		public unsafe int giveMushroomNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_giveMushroomNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_giveMushroomNum)) = value;
			}
		}

		// Token: 0x17001A2E RID: 6702
		// (get) Token: 0x06004D8A RID: 19850 RVA: 0x001AA118 File Offset: 0x001A8318
		// (set) Token: 0x06004D8B RID: 19851 RVA: 0x0002858E File Offset: 0x0002678E
		public unsafe float readyToFly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_readyToFly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_readyToFly)) = value;
			}
		}

		// Token: 0x17001A2F RID: 6703
		// (get) Token: 0x06004D8C RID: 19852 RVA: 0x001AA140 File Offset: 0x001A8340
		// (set) Token: 0x06004D8D RID: 19853 RVA: 0x000285A9 File Offset: 0x000267A9
		public unsafe float dashTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_dashTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_dashTime)) = value;
			}
		}

		// Token: 0x17001A30 RID: 6704
		// (get) Token: 0x06004D8E RID: 19854 RVA: 0x001AA168 File Offset: 0x001A8368
		// (set) Token: 0x06004D8F RID: 19855 RVA: 0x000285C4 File Offset: 0x000267C4
		public unsafe float waitToEscape
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_waitToEscape);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_waitToEscape)) = value;
			}
		}

		// Token: 0x17001A31 RID: 6705
		// (get) Token: 0x06004D90 RID: 19856 RVA: 0x001AA190 File Offset: 0x001A8390
		// (set) Token: 0x06004D91 RID: 19857 RVA: 0x000285DF File Offset: 0x000267DF
		public unsafe Vector3 whereToEscape
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_whereToEscape);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_whereToEscape)) = value;
			}
		}

		// Token: 0x17001A32 RID: 6706
		// (get) Token: 0x06004D92 RID: 19858 RVA: 0x001AA1B8 File Offset: 0x001A83B8
		// (set) Token: 0x06004D93 RID: 19859 RVA: 0x000285FA File Offset: 0x000267FA
		public unsafe float escapeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_escapeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_escapeTime)) = value;
			}
		}

		// Token: 0x17001A33 RID: 6707
		// (get) Token: 0x06004D94 RID: 19860 RVA: 0x001AA1E0 File Offset: 0x001A83E0
		// (set) Token: 0x06004D95 RID: 19861 RVA: 0x00028615 File Offset: 0x00026815
		public unsafe int stealThingNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_stealThingNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_stealThingNum)) = value;
			}
		}

		// Token: 0x17001A34 RID: 6708
		// (get) Token: 0x06004D96 RID: 19862 RVA: 0x001AA208 File Offset: 0x001A8408
		// (set) Token: 0x06004D97 RID: 19863 RVA: 0x00028630 File Offset: 0x00026830
		public unsafe float mushroomStartSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_mushroomStartSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_mushroomStartSpeed)) = value;
			}
		}

		// Token: 0x17001A35 RID: 6709
		// (get) Token: 0x06004D98 RID: 19864 RVA: 0x001AA230 File Offset: 0x001A8430
		// (set) Token: 0x06004D99 RID: 19865 RVA: 0x0002864B File Offset: 0x0002684B
		public unsafe float mushroomStartToDash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_mushroomStartToDash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_mushroomStartToDash)) = value;
			}
		}

		// Token: 0x17001A36 RID: 6710
		// (get) Token: 0x06004D9A RID: 19866 RVA: 0x001AA258 File Offset: 0x001A8458
		// (set) Token: 0x06004D9B RID: 19867 RVA: 0x00028666 File Offset: 0x00026866
		public unsafe float mushroomRotate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_mushroomRotate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_mushroomRotate)) = value;
			}
		}

		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x06004D9C RID: 19868 RVA: 0x001AA280 File Offset: 0x001A8480
		// (set) Token: 0x06004D9D RID: 19869 RVA: 0x00028681 File Offset: 0x00026881
		public unsafe float mushroomAddSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_mushroomAddSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_mushroomAddSpeed)) = value;
			}
		}

		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x06004D9E RID: 19870 RVA: 0x001AA2A8 File Offset: 0x001A84A8
		// (set) Token: 0x06004D9F RID: 19871 RVA: 0x0002869C File Offset: 0x0002689C
		public unsafe float mushroomEndSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_mushroomEndSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_mushroomEndSpeed)) = value;
			}
		}

		// Token: 0x17001A39 RID: 6713
		// (get) Token: 0x06004DA0 RID: 19872 RVA: 0x001AA2D0 File Offset: 0x001A84D0
		// (set) Token: 0x06004DA1 RID: 19873 RVA: 0x000286B7 File Offset: 0x000268B7
		public unsafe float cameraShakeAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_cameraShakeAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_cameraShakeAmplitude)) = value;
			}
		}

		// Token: 0x17001A3A RID: 6714
		// (get) Token: 0x06004DA2 RID: 19874 RVA: 0x001AA2F8 File Offset: 0x001A84F8
		// (set) Token: 0x06004DA3 RID: 19875 RVA: 0x000286D2 File Offset: 0x000268D2
		public unsafe float cameraShakeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_cameraShakeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_cameraShakeDuration)) = value;
			}
		}

		// Token: 0x17001A3B RID: 6715
		// (get) Token: 0x06004DA4 RID: 19876 RVA: 0x001AA320 File Offset: 0x001A8520
		// (set) Token: 0x06004DA5 RID: 19877 RVA: 0x000286ED File Offset: 0x000268ED
		public unsafe float cameraShakeFade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_cameraShakeFade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_cameraShakeFade)) = value;
			}
		}

		// Token: 0x17001A3C RID: 6716
		// (get) Token: 0x06004DA6 RID: 19878 RVA: 0x001AA348 File Offset: 0x001A8548
		// (set) Token: 0x06004DA7 RID: 19879 RVA: 0x00028708 File Offset: 0x00026908
		public unsafe GameObject magicArrayEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_magicArrayEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_magicArrayEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A3D RID: 6717
		// (get) Token: 0x06004DA8 RID: 19880 RVA: 0x001AA378 File Offset: 0x001A8578
		// (set) Token: 0x06004DA9 RID: 19881 RVA: 0x00028727 File Offset: 0x00026927
		public unsafe GameObject magicExplosionEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_magicExplosionEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_magicExplosionEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A3E RID: 6718
		// (get) Token: 0x06004DAA RID: 19882 RVA: 0x001AA3A8 File Offset: 0x001A85A8
		// (set) Token: 0x06004DAB RID: 19883 RVA: 0x00028746 File Offset: 0x00026946
		public unsafe GameObject mushroomMilkyWay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_mushroomMilkyWay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_mushroomMilkyWay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A3F RID: 6719
		// (get) Token: 0x06004DAC RID: 19884 RVA: 0x001AA3D8 File Offset: 0x001A85D8
		// (set) Token: 0x06004DAD RID: 19885 RVA: 0x00028765 File Offset: 0x00026965
		public unsafe float magicArrayDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_magicArrayDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_magicArrayDuration)) = value;
			}
		}

		// Token: 0x17001A40 RID: 6720
		// (get) Token: 0x06004DAE RID: 19886 RVA: 0x001AA400 File Offset: 0x001A8600
		// (set) Token: 0x06004DAF RID: 19887 RVA: 0x00028780 File Offset: 0x00026980
		public unsafe float magicExplosionDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_magicExplosionDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_magicExplosionDuration)) = value;
			}
		}

		// Token: 0x17001A41 RID: 6721
		// (get) Token: 0x06004DB0 RID: 19888 RVA: 0x001AA428 File Offset: 0x001A8628
		// (set) Token: 0x06004DB1 RID: 19889 RVA: 0x0002879B File Offset: 0x0002699B
		public unsafe float milkyWayDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_milkyWayDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_milkyWayDuration)) = value;
			}
		}

		// Token: 0x17001A42 RID: 6722
		// (get) Token: 0x06004DB2 RID: 19890 RVA: 0x001AA450 File Offset: 0x001A8650
		// (set) Token: 0x06004DB3 RID: 19891 RVA: 0x000287B6 File Offset: 0x000269B6
		public unsafe float milkyWayEffectsDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_milkyWayEffectsDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_milkyWayEffectsDuration)) = value;
			}
		}

		// Token: 0x17001A43 RID: 6723
		// (get) Token: 0x06004DB4 RID: 19892 RVA: 0x001AA478 File Offset: 0x001A8678
		// (set) Token: 0x06004DB5 RID: 19893 RVA: 0x000287D1 File Offset: 0x000269D1
		public unsafe GameObject eyeEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_eyeEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_eyeEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A44 RID: 6724
		// (get) Token: 0x06004DB6 RID: 19894 RVA: 0x001AA4A8 File Offset: 0x001A86A8
		// (set) Token: 0x06004DB7 RID: 19895 RVA: 0x000287F0 File Offset: 0x000269F0
		public unsafe GameObject punishmenPic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_punishmenPic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_punishmenPic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A45 RID: 6725
		// (get) Token: 0x06004DB8 RID: 19896 RVA: 0x001AA4D8 File Offset: 0x001A86D8
		// (set) Token: 0x06004DB9 RID: 19897 RVA: 0x0002880F File Offset: 0x00026A0F
		public unsafe GameObject punishmentEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_punishmentEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_punishmentEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x06004DBA RID: 19898 RVA: 0x001AA508 File Offset: 0x001A8708
		// (set) Token: 0x06004DBB RID: 19899 RVA: 0x0002882E File Offset: 0x00026A2E
		public unsafe GameObject stolenThing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_stolenThing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_stolenThing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x06004DBC RID: 19900 RVA: 0x001AA538 File Offset: 0x001A8738
		// (set) Token: 0x06004DBD RID: 19901 RVA: 0x0002884D File Offset: 0x00026A4D
		public unsafe RuntimeAnimatorController punishAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_punishAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_punishAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x06004DBE RID: 19902 RVA: 0x001AA568 File Offset: 0x001A8768
		// (set) Token: 0x06004DBF RID: 19903 RVA: 0x0002886C File Offset: 0x00026A6C
		public unsafe float punishmentPicDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_punishmentPicDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_punishmentPicDuration)) = value;
			}
		}

		// Token: 0x17001A49 RID: 6729
		// (get) Token: 0x06004DC0 RID: 19904 RVA: 0x001AA590 File Offset: 0x001A8790
		// (set) Token: 0x06004DC1 RID: 19905 RVA: 0x00028887 File Offset: 0x00026A87
		public unsafe float effectDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_effectDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.NativeFieldInfoPtr_effectDelay)) = value;
			}
		}

		// Token: 0x040034E4 RID: 13540
		private static readonly IntPtr NativeFieldInfoPtr_giveMushroomNum;

		// Token: 0x040034E5 RID: 13541
		private static readonly IntPtr NativeFieldInfoPtr_readyToFly;

		// Token: 0x040034E6 RID: 13542
		private static readonly IntPtr NativeFieldInfoPtr_dashTime;

		// Token: 0x040034E7 RID: 13543
		private static readonly IntPtr NativeFieldInfoPtr_waitToEscape;

		// Token: 0x040034E8 RID: 13544
		private static readonly IntPtr NativeFieldInfoPtr_whereToEscape;

		// Token: 0x040034E9 RID: 13545
		private static readonly IntPtr NativeFieldInfoPtr_escapeTime;

		// Token: 0x040034EA RID: 13546
		private static readonly IntPtr NativeFieldInfoPtr_stealThingNum;

		// Token: 0x040034EB RID: 13547
		private static readonly IntPtr NativeFieldInfoPtr_mushroomStartSpeed;

		// Token: 0x040034EC RID: 13548
		private static readonly IntPtr NativeFieldInfoPtr_mushroomStartToDash;

		// Token: 0x040034ED RID: 13549
		private static readonly IntPtr NativeFieldInfoPtr_mushroomRotate;

		// Token: 0x040034EE RID: 13550
		private static readonly IntPtr NativeFieldInfoPtr_mushroomAddSpeed;

		// Token: 0x040034EF RID: 13551
		private static readonly IntPtr NativeFieldInfoPtr_mushroomEndSpeed;

		// Token: 0x040034F0 RID: 13552
		private static readonly IntPtr NativeFieldInfoPtr_cameraShakeAmplitude;

		// Token: 0x040034F1 RID: 13553
		private static readonly IntPtr NativeFieldInfoPtr_cameraShakeDuration;

		// Token: 0x040034F2 RID: 13554
		private static readonly IntPtr NativeFieldInfoPtr_cameraShakeFade;

		// Token: 0x040034F3 RID: 13555
		private static readonly IntPtr NativeFieldInfoPtr_magicArrayEffect;

		// Token: 0x040034F4 RID: 13556
		private static readonly IntPtr NativeFieldInfoPtr_magicExplosionEffect;

		// Token: 0x040034F5 RID: 13557
		private static readonly IntPtr NativeFieldInfoPtr_mushroomMilkyWay;

		// Token: 0x040034F6 RID: 13558
		private static readonly IntPtr NativeFieldInfoPtr_magicArrayDuration;

		// Token: 0x040034F7 RID: 13559
		private static readonly IntPtr NativeFieldInfoPtr_magicExplosionDuration;

		// Token: 0x040034F8 RID: 13560
		private static readonly IntPtr NativeFieldInfoPtr_milkyWayDuration;

		// Token: 0x040034F9 RID: 13561
		private static readonly IntPtr NativeFieldInfoPtr_milkyWayEffectsDuration;

		// Token: 0x040034FA RID: 13562
		private static readonly IntPtr NativeFieldInfoPtr_eyeEffect;

		// Token: 0x040034FB RID: 13563
		private static readonly IntPtr NativeFieldInfoPtr_punishmenPic;

		// Token: 0x040034FC RID: 13564
		private static readonly IntPtr NativeFieldInfoPtr_punishmentEffect;

		// Token: 0x040034FD RID: 13565
		private static readonly IntPtr NativeFieldInfoPtr_stolenThing;

		// Token: 0x040034FE RID: 13566
		private static readonly IntPtr NativeFieldInfoPtr_punishAnim;

		// Token: 0x040034FF RID: 13567
		private static readonly IntPtr NativeFieldInfoPtr_punishmentPicDuration;

		// Token: 0x04003500 RID: 13568
		private static readonly IntPtr NativeFieldInfoPtr_effectDelay;

		// Token: 0x04003501 RID: 13569
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x04003502 RID: 13570
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003503 RID: 13571
		private static readonly IntPtr NativeMethodInfoPtr_MarisaStealImportantThings_Private_Sprite_Int32_0;

		// Token: 0x04003504 RID: 13572
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003505 RID: 13573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003506 RID: 13574
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Vector3_0;

		// Token: 0x02000B4F RID: 2895
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Marisa+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D5D3 RID: 54739 RVA: 0x00343548 File Offset: 0x00341748
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass30_0>.NativeClassPtr);
				Spell_Marisa.__c__DisplayClass30_0.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass30_0>.NativeClassPtr, "character");
				Spell_Marisa.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass30_0>.NativeClassPtr, "<>4__this");
				Spell_Marisa.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass30_0>.NativeClassPtr, 100678919);
				Spell_Marisa.__c__DisplayClass30_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass30_0>.NativeClassPtr, 100678920);
				Spell_Marisa.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_Vector3_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass30_0>.NativeClassPtr, 100678921);
				Spell_Marisa.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_Vector3_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass30_0>.NativeClassPtr, 100678922);
			}

			// Token: 0x0600D5D4 RID: 54740 RVA: 0x003435EC File Offset: 0x003417EC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5D5 RID: 54741 RVA: 0x00343628 File Offset: 0x00341828
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198975, XrefRangeEnd = 198979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa.__c__DisplayClass30_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5D6 RID: 54742 RVA: 0x0034366C File Offset: 0x0034186C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198979, XrefRangeEnd = 198980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 Method_Internal_Vector3_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_Vector3_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D5D7 RID: 54743 RVA: 0x003436A8 File Offset: 0x003418A8
			[CallerCount(0)]
			public unsafe Vector3 Method_Internal_Vector3_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_Vector3_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D5D8 RID: 54744 RVA: 0x000726F6 File Offset: 0x000708F6
			public __c__DisplayClass30_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700458D RID: 17805
			// (get) Token: 0x0600D5D9 RID: 54745 RVA: 0x003436E4 File Offset: 0x003418E4
			// (set) Token: 0x0600D5DA RID: 54746 RVA: 0x000726FF File Offset: 0x000708FF
			public unsafe AStarInputGeneratorComponent character
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass30_0.NativeFieldInfoPtr_character);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AStarInputGeneratorComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass30_0.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700458E RID: 17806
			// (get) Token: 0x0600D5DB RID: 54747 RVA: 0x00343714 File Offset: 0x00341914
			// (set) Token: 0x0600D5DC RID: 54748 RVA: 0x0007271E File Offset: 0x0007091E
			public unsafe Spell_Marisa __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Marisa>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400892F RID: 35119
			private static readonly IntPtr NativeFieldInfoPtr_character;

			// Token: 0x04008930 RID: 35120
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008931 RID: 35121
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008932 RID: 35122
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0;

			// Token: 0x04008933 RID: 35123
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Vector3_PDM_0;

			// Token: 0x04008934 RID: 35124
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Vector3_PDM_1;
		}

		// Token: 0x02000B50 RID: 2896
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Marisa+<OnNegativeBuffExecute>d__30")]
		public sealed class _OnNegativeBuffExecute_d__30 : Il2CppSystem.Object
		{
			// Token: 0x0600D5DD RID: 54749 RVA: 0x00343744 File Offset: 0x00341944
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__30()
			{
				Il2CppClassPointerStore<Spell_Marisa._OnNegativeBuffExecute_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "<OnNegativeBuffExecute>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Marisa._OnNegativeBuffExecute_d__30>.NativeClassPtr);
				Spell_Marisa._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa._OnNegativeBuffExecute_d__30>.NativeClassPtr, "<>1__state");
				Spell_Marisa._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa._OnNegativeBuffExecute_d__30>.NativeClassPtr, "<>2__current");
				Spell_Marisa._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa._OnNegativeBuffExecute_d__30>.NativeClassPtr, "<>4__this");
				Spell_Marisa._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa._OnNegativeBuffExecute_d__30>.NativeClassPtr, "spellExecutionContext");
				Spell_Marisa._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa._OnNegativeBuffExecute_d__30>.NativeClassPtr, "<>8__1");
				Spell_Marisa._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr__characterControllerUnit_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa._OnNegativeBuffExecute_d__30>.NativeClassPtr, "<characterControllerUnit>5__2");
				Spell_Marisa._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr__characterPixel_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa._OnNegativeBuffExecute_d__30>.NativeClassPtr, "<characterPixel>5__3");
				Spell_Marisa._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa._OnNegativeBuffExecute_d__30>.NativeClassPtr, 100678923);
				Spell_Marisa._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa._OnNegativeBuffExecute_d__30>.NativeClassPtr, 100678924);
				Spell_Marisa._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa._OnNegativeBuffExecute_d__30>.NativeClassPtr, 100678925);
				Spell_Marisa._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa._OnNegativeBuffExecute_d__30>.NativeClassPtr, 100678926);
				Spell_Marisa._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa._OnNegativeBuffExecute_d__30>.NativeClassPtr, 100678927);
				Spell_Marisa._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa._OnNegativeBuffExecute_d__30>.NativeClassPtr, 100678928);
			}

			// Token: 0x0600D5DE RID: 54750 RVA: 0x00343874 File Offset: 0x00341A74
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__30(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Marisa._OnNegativeBuffExecute_d__30>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5DF RID: 54751 RVA: 0x003438BC File Offset: 0x00341ABC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5E0 RID: 54752 RVA: 0x003438F0 File Offset: 0x00341AF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198980, XrefRangeEnd = 199127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004596 RID: 17814
			// (get) Token: 0x0600D5E1 RID: 54753 RVA: 0x0034392C File Offset: 0x00341B2C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D5E2 RID: 54754 RVA: 0x0034396C File Offset: 0x00341B6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199127, XrefRangeEnd = 199133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004597 RID: 17815
			// (get) Token: 0x0600D5E3 RID: 54755 RVA: 0x003439A0 File Offset: 0x00341BA0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D5E4 RID: 54756 RVA: 0x0007273D File Offset: 0x0007093D
			public _OnNegativeBuffExecute_d__30(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700458F RID: 17807
			// (get) Token: 0x0600D5E5 RID: 54757 RVA: 0x003439E0 File Offset: 0x00341BE0
			// (set) Token: 0x0600D5E6 RID: 54758 RVA: 0x00072746 File Offset: 0x00070946
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004590 RID: 17808
			// (get) Token: 0x0600D5E7 RID: 54759 RVA: 0x00343A08 File Offset: 0x00341C08
			// (set) Token: 0x0600D5E8 RID: 54760 RVA: 0x00072761 File Offset: 0x00070961
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004591 RID: 17809
			// (get) Token: 0x0600D5E9 RID: 54761 RVA: 0x00343A38 File Offset: 0x00341C38
			// (set) Token: 0x0600D5EA RID: 54762 RVA: 0x00072780 File Offset: 0x00070980
			public unsafe Spell_Marisa __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Marisa>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004592 RID: 17810
			// (get) Token: 0x0600D5EB RID: 54763 RVA: 0x00343A68 File Offset: 0x00341C68
			// (set) Token: 0x0600D5EC RID: 54764 RVA: 0x0007279F File Offset: 0x0007099F
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004593 RID: 17811
			// (get) Token: 0x0600D5ED RID: 54765 RVA: 0x00343A98 File Offset: 0x00341C98
			// (set) Token: 0x0600D5EE RID: 54766 RVA: 0x000727BE File Offset: 0x000709BE
			public unsafe Spell_Marisa.__c__DisplayClass30_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Marisa.__c__DisplayClass30_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004594 RID: 17812
			// (get) Token: 0x0600D5EF RID: 54767 RVA: 0x00343AC8 File Offset: 0x00341CC8
			// (set) Token: 0x0600D5F0 RID: 54768 RVA: 0x000727DD File Offset: 0x000709DD
			public unsafe CharacterControllerUnit _characterControllerUnit_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr__characterControllerUnit_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr__characterControllerUnit_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004595 RID: 17813
			// (get) Token: 0x0600D5F1 RID: 54769 RVA: 0x00343AF8 File Offset: 0x00341CF8
			// (set) Token: 0x0600D5F2 RID: 54770 RVA: 0x000727FC File Offset: 0x000709FC
			public unsafe CharacterSpriteSetCompact _characterPixel_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr__characterPixel_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr__characterPixel_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008935 RID: 35125
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008936 RID: 35126
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008937 RID: 35127
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008938 RID: 35128
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008939 RID: 35129
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400893A RID: 35130
			private static readonly IntPtr NativeFieldInfoPtr__characterControllerUnit_5__2;

			// Token: 0x0400893B RID: 35131
			private static readonly IntPtr NativeFieldInfoPtr__characterPixel_5__3;

			// Token: 0x0400893C RID: 35132
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400893D RID: 35133
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400893E RID: 35134
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400893F RID: 35135
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008940 RID: 35136
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008941 RID: 35137
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B51 RID: 2897
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Marisa+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D5F3 RID: 54771 RVA: 0x00343B28 File Offset: 0x00341D28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass31_0>.NativeClassPtr);
				Spell_Marisa.__c__DisplayClass31_0.NativeFieldInfoPtr_ifSelectValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass31_0>.NativeClassPtr, "ifSelectValue");
				Spell_Marisa.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass31_0>.NativeClassPtr, 100678929);
				Spell_Marisa.__c__DisplayClass31_0.NativeMethodInfoPtr__MarisaStealImportantThings_b__0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass31_0>.NativeClassPtr, 100678930);
			}

			// Token: 0x0600D5F4 RID: 54772 RVA: 0x00343B90 File Offset: 0x00341D90
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5F5 RID: 54773 RVA: 0x00343BCC File Offset: 0x00341DCC
			[CallerCount(0)]
			public unsafe bool _MarisaStealImportantThings_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa.__c__DisplayClass31_0.NativeMethodInfoPtr__MarisaStealImportantThings_b__0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D5F6 RID: 54774 RVA: 0x0007281B File Offset: 0x00070A1B
			public __c__DisplayClass31_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004598 RID: 17816
			// (get) Token: 0x0600D5F7 RID: 54775 RVA: 0x00343C18 File Offset: 0x00341E18
			// (set) Token: 0x0600D5F8 RID: 54776 RVA: 0x00072824 File Offset: 0x00070A24
			public unsafe Il2CppStructArray<bool> ifSelectValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass31_0.NativeFieldInfoPtr_ifSelectValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass31_0.NativeFieldInfoPtr_ifSelectValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008942 RID: 35138
			private static readonly IntPtr NativeFieldInfoPtr_ifSelectValue;

			// Token: 0x04008943 RID: 35139
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008944 RID: 35140
			private static readonly IntPtr NativeMethodInfoPtr__MarisaStealImportantThings_b__0_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000B52 RID: 2898
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Marisa+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D5F9 RID: 54777 RVA: 0x00343C48 File Offset: 0x00341E48
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0>.NativeClassPtr);
				Spell_Marisa.__c__DisplayClass32_0.NativeFieldInfoPtr_flyingMushroom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0>.NativeClassPtr, "flyingMushroom");
				Spell_Marisa.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0>.NativeClassPtr, "<>4__this");
				Spell_Marisa.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0>.NativeClassPtr, 100678931);
				Spell_Marisa.__c__DisplayClass32_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_SelectedValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0>.NativeClassPtr, 100678932);
				Spell_Marisa.__c__DisplayClass32_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Transform_Vector3_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0>.NativeClassPtr, 100678933);
			}

			// Token: 0x0600D5FA RID: 54778 RVA: 0x00343CD8 File Offset: 0x00341ED8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5FB RID: 54779 RVA: 0x00343D14 File Offset: 0x00341F14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199142, XrefRangeEnd = 199144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__0(EventManager.SelectedValue x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa.__c__DisplayClass32_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_SelectedValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5FC RID: 54780 RVA: 0x00343D5C File Offset: 0x00341F5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199144, XrefRangeEnd = 199150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Transform_Vector3_Single_PDM_0(Transform source, Vector3 targetPosition, float duration)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetPosition;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa.__c__DisplayClass32_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Transform_Vector3_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D5FD RID: 54781 RVA: 0x00072843 File Offset: 0x00070A43
			public __c__DisplayClass32_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004599 RID: 17817
			// (get) Token: 0x0600D5FE RID: 54782 RVA: 0x00343DC8 File Offset: 0x00341FC8
			// (set) Token: 0x0600D5FF RID: 54783 RVA: 0x0007284C File Offset: 0x00070A4C
			public unsafe Il2CppReferenceArray<GameObject> flyingMushroom
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_0.NativeFieldInfoPtr_flyingMushroom);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_0.NativeFieldInfoPtr_flyingMushroom), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700459A RID: 17818
			// (get) Token: 0x0600D600 RID: 54784 RVA: 0x00343DF8 File Offset: 0x00341FF8
			// (set) Token: 0x0600D601 RID: 54785 RVA: 0x0007286B File Offset: 0x00070A6B
			public unsafe Spell_Marisa __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Marisa>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008945 RID: 35141
			private static readonly IntPtr NativeFieldInfoPtr_flyingMushroom;

			// Token: 0x04008946 RID: 35142
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008947 RID: 35143
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008948 RID: 35144
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_SelectedValue_0;

			// Token: 0x04008949 RID: 35145
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Transform_Vector3_Single_PDM_0;

			// Token: 0x0200102E RID: 4142
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Marisa+<>c__DisplayClass32_0+<<OnPositiveBuffExecute>g__MilkyWay|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011B88 RID: 72584 RVA: 0x0040F3F4 File Offset: 0x0040D5F4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique()
				{
					Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0>.NativeClassPtr, "<<OnPositiveBuffExecute>g__MilkyWay|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique>.NativeClassPtr);
					Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique>.NativeClassPtr, "<>1__state");
					Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique>.NativeClassPtr, "<>2__current");
					Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique>.NativeClassPtr, "targetPosition");
					Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique>.NativeClassPtr, "<>4__this");
					Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique>.NativeClassPtr, "source");
					Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique>.NativeClassPtr, "<>8__1");
					Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique>.NativeClassPtr, "duration");
					Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr__speed_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique>.NativeClassPtr, "<speed>5__2");
					Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr__time_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique>.NativeClassPtr, "<time>5__3");
					Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique>.NativeClassPtr, 100678934);
					Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique>.NativeClassPtr, 100678935);
					Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique>.NativeClassPtr, 100678936);
					Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique>.NativeClassPtr, 100678937);
					Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique>.NativeClassPtr, 100678938);
					Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique>.NativeClassPtr, 100678939);
				}

				// Token: 0x06011B89 RID: 72585 RVA: 0x0040F54C File Offset: 0x0040D74C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011B8A RID: 72586 RVA: 0x0040F594 File Offset: 0x0040D794
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011B8B RID: 72587 RVA: 0x0040F5C8 File Offset: 0x0040D7C8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199133, XrefRangeEnd = 199136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C45 RID: 23621
				// (get) Token: 0x06011B8C RID: 72588 RVA: 0x0040F604 File Offset: 0x0040D804
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011B8D RID: 72589 RVA: 0x0040F644 File Offset: 0x0040D844
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199136, XrefRangeEnd = 199142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C46 RID: 23622
				// (get) Token: 0x06011B8E RID: 72590 RVA: 0x0040F678 File Offset: 0x0040D878
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011B8F RID: 72591 RVA: 0x0009A092 File Offset: 0x00098292
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C3C RID: 23612
				// (get) Token: 0x06011B90 RID: 72592 RVA: 0x0040F6B8 File Offset: 0x0040D8B8
				// (set) Token: 0x06011B91 RID: 72593 RVA: 0x0009A09B File Offset: 0x0009829B
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C3D RID: 23613
				// (get) Token: 0x06011B92 RID: 72594 RVA: 0x0040F6E0 File Offset: 0x0040D8E0
				// (set) Token: 0x06011B93 RID: 72595 RVA: 0x0009A0B6 File Offset: 0x000982B6
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C3E RID: 23614
				// (get) Token: 0x06011B94 RID: 72596 RVA: 0x0040F710 File Offset: 0x0040D910
				// (set) Token: 0x06011B95 RID: 72597 RVA: 0x0009A0D5 File Offset: 0x000982D5
				public unsafe Vector3 targetPosition
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr_targetPosition);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr_targetPosition)) = value;
					}
				}

				// Token: 0x17005C3F RID: 23615
				// (get) Token: 0x06011B96 RID: 72598 RVA: 0x0040F738 File Offset: 0x0040D938
				// (set) Token: 0x06011B97 RID: 72599 RVA: 0x0009A0F0 File Offset: 0x000982F0
				public unsafe Spell_Marisa.__c__DisplayClass32_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Marisa.__c__DisplayClass32_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C40 RID: 23616
				// (get) Token: 0x06011B98 RID: 72600 RVA: 0x0040F768 File Offset: 0x0040D968
				// (set) Token: 0x06011B99 RID: 72601 RVA: 0x0009A10F File Offset: 0x0009830F
				public unsafe Transform source
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr_source);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C41 RID: 23617
				// (get) Token: 0x06011B9A RID: 72602 RVA: 0x0040F798 File Offset: 0x0040D998
				// (set) Token: 0x06011B9B RID: 72603 RVA: 0x0009A12E File Offset: 0x0009832E
				public unsafe Spell_Marisa.__c__DisplayClass32_2 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Marisa.__c__DisplayClass32_2>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C42 RID: 23618
				// (get) Token: 0x06011B9C RID: 72604 RVA: 0x0040F7C8 File Offset: 0x0040D9C8
				// (set) Token: 0x06011B9D RID: 72605 RVA: 0x0009A14D File Offset: 0x0009834D
				public unsafe float duration
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr_duration);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr_duration)) = value;
					}
				}

				// Token: 0x17005C43 RID: 23619
				// (get) Token: 0x06011B9E RID: 72606 RVA: 0x0040F7F0 File Offset: 0x0040D9F0
				// (set) Token: 0x06011B9F RID: 72607 RVA: 0x0009A168 File Offset: 0x00098368
				public unsafe float _speed_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr__speed_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr__speed_5__2)) = value;
					}
				}

				// Token: 0x17005C44 RID: 23620
				// (get) Token: 0x06011BA0 RID: 72608 RVA: 0x0040F818 File Offset: 0x0040DA18
				// (set) Token: 0x06011BA1 RID: 72609 RVA: 0x0009A183 File Offset: 0x00098383
				public unsafe float _time_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr__time_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTrsoSiduSiObUnique.NativeFieldInfoPtr__time_5__3)) = value;
					}
				}

				// Token: 0x0400B321 RID: 45857
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B322 RID: 45858
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B323 RID: 45859
				private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

				// Token: 0x0400B324 RID: 45860
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B325 RID: 45861
				private static readonly IntPtr NativeFieldInfoPtr_source;

				// Token: 0x0400B326 RID: 45862
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400B327 RID: 45863
				private static readonly IntPtr NativeFieldInfoPtr_duration;

				// Token: 0x0400B328 RID: 45864
				private static readonly IntPtr NativeFieldInfoPtr__speed_5__2;

				// Token: 0x0400B329 RID: 45865
				private static readonly IntPtr NativeFieldInfoPtr__time_5__3;

				// Token: 0x0400B32A RID: 45866
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B32B RID: 45867
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B32C RID: 45868
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B32D RID: 45869
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B32E RID: 45870
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B32F RID: 45871
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B53 RID: 2899
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Marisa+<>c__DisplayClass32_1")]
		public sealed class __c__DisplayClass32_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D602 RID: 54786 RVA: 0x00343E28 File Offset: 0x00342028
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_1()
			{
				Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "<>c__DisplayClass32_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_1>.NativeClassPtr);
				Spell_Marisa.__c__DisplayClass32_1.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_1>.NativeClassPtr, "i");
				Spell_Marisa.__c__DisplayClass32_1.NativeFieldInfoPtr_field_Public___c__DisplayClass32_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_1>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Marisa.__c__DisplayClass32_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_1>.NativeClassPtr, 100678940);
				Spell_Marisa.__c__DisplayClass32_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_1>.NativeClassPtr, 100678941);
			}

			// Token: 0x0600D603 RID: 54787 RVA: 0x00343EA4 File Offset: 0x003420A4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa.__c__DisplayClass32_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D604 RID: 54788 RVA: 0x00343EE0 File Offset: 0x003420E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199150, XrefRangeEnd = 199156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__2(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa.__c__DisplayClass32_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D605 RID: 54789 RVA: 0x0007288A File Offset: 0x00070A8A
			public __c__DisplayClass32_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700459B RID: 17819
			// (get) Token: 0x0600D606 RID: 54790 RVA: 0x00343F24 File Offset: 0x00342124
			// (set) Token: 0x0600D607 RID: 54791 RVA: 0x00072893 File Offset: 0x00070A93
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_1.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_1.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x1700459C RID: 17820
			// (get) Token: 0x0600D608 RID: 54792 RVA: 0x00343F4C File Offset: 0x0034214C
			// (set) Token: 0x0600D609 RID: 54793 RVA: 0x000728AE File Offset: 0x00070AAE
			public unsafe Spell_Marisa.__c__DisplayClass32_0 field_Public___c__DisplayClass32_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_1.NativeFieldInfoPtr_field_Public___c__DisplayClass32_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Marisa.__c__DisplayClass32_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_1.NativeFieldInfoPtr_field_Public___c__DisplayClass32_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400894A RID: 35146
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x0400894B RID: 35147
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass32_0_0;

			// Token: 0x0400894C RID: 35148
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400894D RID: 35149
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GameObject_0;
		}

		// Token: 0x02000B54 RID: 2900
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Marisa+<>c__DisplayClass32_2")]
		public sealed class __c__DisplayClass32_2 : Il2CppSystem.Object
		{
			// Token: 0x0600D60A RID: 54794 RVA: 0x00343F7C File Offset: 0x0034217C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_2()
			{
				Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "<>c__DisplayClass32_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_2>.NativeClassPtr);
				Spell_Marisa.__c__DisplayClass32_2.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_2>.NativeClassPtr, "targetPosition");
				Spell_Marisa.__c__DisplayClass32_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_2>.NativeClassPtr, 100678942);
				Spell_Marisa.__c__DisplayClass32_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_2>.NativeClassPtr, 100678943);
			}

			// Token: 0x0600D60B RID: 54795 RVA: 0x00343FE4 File Offset: 0x003421E4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Marisa.__c__DisplayClass32_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa.__c__DisplayClass32_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D60C RID: 54796 RVA: 0x00344020 File Offset: 0x00342220
			[CallerCount(0)]
			public unsafe Vector3 _OnPositiveBuffExecute_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa.__c__DisplayClass32_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D60D RID: 54797 RVA: 0x000728CD File Offset: 0x00070ACD
			public __c__DisplayClass32_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700459D RID: 17821
			// (get) Token: 0x0600D60E RID: 54798 RVA: 0x0034405C File Offset: 0x0034225C
			// (set) Token: 0x0600D60F RID: 54799 RVA: 0x000728D6 File Offset: 0x00070AD6
			public unsafe Vector3 targetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_2.NativeFieldInfoPtr_targetPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa.__c__DisplayClass32_2.NativeFieldInfoPtr_targetPosition)) = value;
				}
			}

			// Token: 0x0400894E RID: 35150
			private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

			// Token: 0x0400894F RID: 35151
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008950 RID: 35152
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Vector3_0;
		}

		// Token: 0x02000B55 RID: 2901
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Marisa+<OnPositiveBuffExecute>d__32")]
		public sealed class _OnPositiveBuffExecute_d__32 : Il2CppSystem.Object
		{
			// Token: 0x0600D610 RID: 54800 RVA: 0x00344084 File Offset: 0x00342284
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__32()
			{
				Il2CppClassPointerStore<Spell_Marisa._OnPositiveBuffExecute_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Marisa>.NativeClassPtr, "<OnPositiveBuffExecute>d__32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Marisa._OnPositiveBuffExecute_d__32>.NativeClassPtr);
				Spell_Marisa._OnPositiveBuffExecute_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa._OnPositiveBuffExecute_d__32>.NativeClassPtr, "<>1__state");
				Spell_Marisa._OnPositiveBuffExecute_d__32.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa._OnPositiveBuffExecute_d__32>.NativeClassPtr, "<>2__current");
				Spell_Marisa._OnPositiveBuffExecute_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa._OnPositiveBuffExecute_d__32>.NativeClassPtr, "<>4__this");
				Spell_Marisa._OnPositiveBuffExecute_d__32.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa._OnPositiveBuffExecute_d__32>.NativeClassPtr, "spellExecutionContext");
				Spell_Marisa._OnPositiveBuffExecute_d__32.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa._OnPositiveBuffExecute_d__32>.NativeClassPtr, "<>8__1");
				Spell_Marisa._OnPositiveBuffExecute_d__32.NativeFieldInfoPtr__selections_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Marisa._OnPositiveBuffExecute_d__32>.NativeClassPtr, "<selections>5__2");
				Spell_Marisa._OnPositiveBuffExecute_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa._OnPositiveBuffExecute_d__32>.NativeClassPtr, 100678944);
				Spell_Marisa._OnPositiveBuffExecute_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa._OnPositiveBuffExecute_d__32>.NativeClassPtr, 100678945);
				Spell_Marisa._OnPositiveBuffExecute_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa._OnPositiveBuffExecute_d__32>.NativeClassPtr, 100678946);
				Spell_Marisa._OnPositiveBuffExecute_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa._OnPositiveBuffExecute_d__32>.NativeClassPtr, 100678947);
				Spell_Marisa._OnPositiveBuffExecute_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa._OnPositiveBuffExecute_d__32>.NativeClassPtr, 100678948);
				Spell_Marisa._OnPositiveBuffExecute_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Marisa._OnPositiveBuffExecute_d__32>.NativeClassPtr, 100678949);
			}

			// Token: 0x0600D611 RID: 54801 RVA: 0x003441A0 File Offset: 0x003423A0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__32(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Marisa._OnPositiveBuffExecute_d__32>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa._OnPositiveBuffExecute_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D612 RID: 54802 RVA: 0x003441E8 File Offset: 0x003423E8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa._OnPositiveBuffExecute_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D613 RID: 54803 RVA: 0x0034421C File Offset: 0x0034241C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199156, XrefRangeEnd = 199235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa._OnPositiveBuffExecute_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170045A4 RID: 17828
			// (get) Token: 0x0600D614 RID: 54804 RVA: 0x00344258 File Offset: 0x00342458
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa._OnPositiveBuffExecute_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D615 RID: 54805 RVA: 0x00344298 File Offset: 0x00342498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199235, XrefRangeEnd = 199241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa._OnPositiveBuffExecute_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170045A5 RID: 17829
			// (get) Token: 0x0600D616 RID: 54806 RVA: 0x003442CC File Offset: 0x003424CC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Marisa._OnPositiveBuffExecute_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D617 RID: 54807 RVA: 0x000728F1 File Offset: 0x00070AF1
			public _OnPositiveBuffExecute_d__32(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700459E RID: 17822
			// (get) Token: 0x0600D618 RID: 54808 RVA: 0x0034430C File Offset: 0x0034250C
			// (set) Token: 0x0600D619 RID: 54809 RVA: 0x000728FA File Offset: 0x00070AFA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnPositiveBuffExecute_d__32.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnPositiveBuffExecute_d__32.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700459F RID: 17823
			// (get) Token: 0x0600D61A RID: 54810 RVA: 0x00344334 File Offset: 0x00342534
			// (set) Token: 0x0600D61B RID: 54811 RVA: 0x00072915 File Offset: 0x00070B15
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnPositiveBuffExecute_d__32.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnPositiveBuffExecute_d__32.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045A0 RID: 17824
			// (get) Token: 0x0600D61C RID: 54812 RVA: 0x00344364 File Offset: 0x00342564
			// (set) Token: 0x0600D61D RID: 54813 RVA: 0x00072934 File Offset: 0x00070B34
			public unsafe Spell_Marisa __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnPositiveBuffExecute_d__32.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Marisa>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnPositiveBuffExecute_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045A1 RID: 17825
			// (get) Token: 0x0600D61E RID: 54814 RVA: 0x00344394 File Offset: 0x00342594
			// (set) Token: 0x0600D61F RID: 54815 RVA: 0x00072953 File Offset: 0x00070B53
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnPositiveBuffExecute_d__32.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnPositiveBuffExecute_d__32.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045A2 RID: 17826
			// (get) Token: 0x0600D620 RID: 54816 RVA: 0x003443C4 File Offset: 0x003425C4
			// (set) Token: 0x0600D621 RID: 54817 RVA: 0x00072972 File Offset: 0x00070B72
			public unsafe Spell_Marisa.__c__DisplayClass32_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnPositiveBuffExecute_d__32.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Marisa.__c__DisplayClass32_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnPositiveBuffExecute_d__32.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045A3 RID: 17827
			// (get) Token: 0x0600D622 RID: 54818 RVA: 0x003443F4 File Offset: 0x003425F4
			// (set) Token: 0x0600D623 RID: 54819 RVA: 0x00072991 File Offset: 0x00070B91
			public unsafe List<EventManager.SelectedValue> _selections_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnPositiveBuffExecute_d__32.NativeFieldInfoPtr__selections_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EventManager.SelectedValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Marisa._OnPositiveBuffExecute_d__32.NativeFieldInfoPtr__selections_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008951 RID: 35153
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008952 RID: 35154
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008953 RID: 35155
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008954 RID: 35156
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008955 RID: 35157
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008956 RID: 35158
			private static readonly IntPtr NativeFieldInfoPtr__selections_5__2;

			// Token: 0x04008957 RID: 35159
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008958 RID: 35160
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008959 RID: 35161
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400895A RID: 35162
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400895B RID: 35163
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400895C RID: 35164
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
