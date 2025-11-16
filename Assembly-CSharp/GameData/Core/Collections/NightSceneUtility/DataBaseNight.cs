using System;
using DEYU.AssetHandleUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x02000247 RID: 583
	public static class DataBaseNight : Il2CppSystem.Object
	{
		// Token: 0x060048B0 RID: 18608 RVA: 0x0019AB54 File Offset: 0x00198D54
		// Note: this type is marked as 'beforefieldinit'.
		static DataBaseNight()
		{
			Il2CppClassPointerStore<DataBaseNight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility", "DataBaseNight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseNight>.NativeClassPtr);
			DataBaseNight.NativeFieldInfoPtr__SpecialGuestSpell_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseNight>.NativeClassPtr, "<SpecialGuestSpell>k__BackingField");
			DataBaseNight.NativeFieldInfoPtr__SpecialGuestSpellMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseNight>.NativeClassPtr, "<SpecialGuestSpellMapping>k__BackingField");
			DataBaseNight.NativeFieldInfoPtr__SpecialGuestSpellPortrayal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseNight>.NativeClassPtr, "<SpecialGuestSpellPortrayal>k__BackingField");
			DataBaseNight.NativeMethodInfoPtr_get_SpecialGuestSpell_Private_Static_get_Dictionary_2_Int32_IAssetHandle_1_SpellBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseNight>.NativeClassPtr, 100677820);
			DataBaseNight.NativeMethodInfoPtr_set_SpecialGuestSpell_Private_Static_set_Void_Dictionary_2_Int32_IAssetHandle_1_SpellBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseNight>.NativeClassPtr, 100677821);
			DataBaseNight.NativeMethodInfoPtr_get_SpecialGuestSpellMapping_Private_Static_get_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseNight>.NativeClassPtr, 100677822);
			DataBaseNight.NativeMethodInfoPtr_set_SpecialGuestSpellMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseNight>.NativeClassPtr, 100677823);
			DataBaseNight.NativeMethodInfoPtr_get_SpecialGuestSpellPortrayal_Private_Static_get_Dictionary_2_Int32_ValueTuple_2_IAssetHandle_1_Sprite_IAssetHandle_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseNight>.NativeClassPtr, 100677824);
			DataBaseNight.NativeMethodInfoPtr_set_SpecialGuestSpellPortrayal_Private_Static_set_Void_Dictionary_2_Int32_ValueTuple_2_IAssetHandle_1_Sprite_IAssetHandle_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseNight>.NativeClassPtr, 100677825);
			DataBaseNight.NativeMethodInfoPtr_Initialize_Public_Static_Void_Dictionary_2_String_DataBaseNightData_Dictionary_2_Int32_ValueTuple_2_IAssetHandle_1_Sprite_IAssetHandle_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseNight>.NativeClassPtr, 100677826);
			DataBaseNight.NativeMethodInfoPtr_WorkSceneGetSpellPortrayal_Public_Static_Sprite_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseNight>.NativeClassPtr, 100677827);
			DataBaseNight.NativeMethodInfoPtr_WorkSceneGetSpell_Public_Static_SpellBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseNight>.NativeClassPtr, 100677828);
			DataBaseNight.NativeMethodInfoPtr_UnloadWorkSceneData_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseNight>.NativeClassPtr, 100677829);
		}

		// Token: 0x1700184C RID: 6220
		// (get) Token: 0x060048B1 RID: 18609 RVA: 0x0019AC88 File Offset: 0x00198E88
		// (set) Token: 0x060048B2 RID: 18610 RVA: 0x0019ACBC File Offset: 0x00198EBC
		public unsafe static Dictionary<int, IAssetHandle<SpellBase>> SpecialGuestSpell
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190531, XrefRangeEnd = 190533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseNight.NativeMethodInfoPtr_get_SpecialGuestSpell_Private_Static_get_Dictionary_2_Int32_IAssetHandle_1_SpellBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, IAssetHandle<SpellBase>>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190533, XrefRangeEnd = 190537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseNight.NativeMethodInfoPtr_set_SpecialGuestSpell_Private_Static_set_Void_Dictionary_2_Int32_IAssetHandle_1_SpellBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700184D RID: 6221
		// (get) Token: 0x060048B3 RID: 18611 RVA: 0x0019ACF4 File Offset: 0x00198EF4
		// (set) Token: 0x060048B4 RID: 18612 RVA: 0x0019AD28 File Offset: 0x00198F28
		public unsafe static Dictionary<int, string> SpecialGuestSpellMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190537, XrefRangeEnd = 190539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseNight.NativeMethodInfoPtr_get_SpecialGuestSpellMapping_Private_Static_get_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190539, XrefRangeEnd = 190543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseNight.NativeMethodInfoPtr_set_SpecialGuestSpellMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700184E RID: 6222
		// (get) Token: 0x060048B5 RID: 18613 RVA: 0x0019AD60 File Offset: 0x00198F60
		// (set) Token: 0x060048B6 RID: 18614 RVA: 0x0019AD94 File Offset: 0x00198F94
		public unsafe static Dictionary<int, ValueTuple<IAssetHandle<Sprite>, IAssetHandle<Sprite>>> SpecialGuestSpellPortrayal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190543, XrefRangeEnd = 190545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseNight.NativeMethodInfoPtr_get_SpecialGuestSpellPortrayal_Private_Static_get_Dictionary_2_Int32_ValueTuple_2_IAssetHandle_1_Sprite_IAssetHandle_1_Sprite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ValueTuple<IAssetHandle<Sprite>, IAssetHandle<Sprite>>>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190545, XrefRangeEnd = 190549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseNight.NativeMethodInfoPtr_set_SpecialGuestSpellPortrayal_Private_Static_set_Void_Dictionary_2_Int32_ValueTuple_2_IAssetHandle_1_Sprite_IAssetHandle_1_Sprite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048B7 RID: 18615 RVA: 0x0019ADCC File Offset: 0x00198FCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190596, RefRangeEnd = 190597, XrefRangeStart = 190549, XrefRangeEnd = 190596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(Dictionary<string, DataBaseNight.DataBaseNightData> nightData, Dictionary<int, ValueTuple<IAssetHandle<Sprite>, IAssetHandle<Sprite>>> characterPortrayalDictionary)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(nightData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterPortrayalDictionary);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseNight.NativeMethodInfoPtr_Initialize_Public_Static_Void_Dictionary_2_String_DataBaseNightData_Dictionary_2_Int32_ValueTuple_2_IAssetHandle_1_Sprite_IAssetHandle_1_Sprite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048B8 RID: 18616 RVA: 0x0019AE14 File Offset: 0x00199014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190597, XrefRangeEnd = 190611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sprite WorkSceneGetSpellPortrayal(int specialGuestId, bool isPositiveSpellCard)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGuestId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPositiveSpellCard;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseNight.NativeMethodInfoPtr_WorkSceneGetSpellPortrayal_Public_Static_Sprite_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x060048B9 RID: 18617 RVA: 0x0019AE64 File Offset: 0x00199064
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 190625, RefRangeEnd = 190634, XrefRangeStart = 190611, XrefRangeEnd = 190625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SpellBase WorkSceneGetSpell(int specialGuestId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGuestId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseNight.NativeMethodInfoPtr_WorkSceneGetSpell_Public_Static_SpellBase_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpellBase>(intPtr3) : null;
		}

		// Token: 0x060048BA RID: 18618 RVA: 0x0019AEA4 File Offset: 0x001990A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 190691, RefRangeEnd = 190693, XrefRangeStart = 190634, XrefRangeEnd = 190691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnloadWorkSceneData()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseNight.NativeMethodInfoPtr_UnloadWorkSceneData_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048BB RID: 18619 RVA: 0x000254D6 File Offset: 0x000236D6
		public DataBaseNight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001849 RID: 6217
		// (get) Token: 0x060048BC RID: 18620 RVA: 0x0019AECC File Offset: 0x001990CC
		// (set) Token: 0x060048BD RID: 18621 RVA: 0x000254DF File Offset: 0x000236DF
		public unsafe static Dictionary<int, IAssetHandle<SpellBase>> _SpecialGuestSpell_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseNight.NativeFieldInfoPtr__SpecialGuestSpell_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, IAssetHandle<SpellBase>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseNight.NativeFieldInfoPtr__SpecialGuestSpell_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700184A RID: 6218
		// (get) Token: 0x060048BE RID: 18622 RVA: 0x0019AEF4 File Offset: 0x001990F4
		// (set) Token: 0x060048BF RID: 18623 RVA: 0x000254F1 File Offset: 0x000236F1
		public unsafe static Dictionary<int, string> _SpecialGuestSpellMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseNight.NativeFieldInfoPtr__SpecialGuestSpellMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseNight.NativeFieldInfoPtr__SpecialGuestSpellMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700184B RID: 6219
		// (get) Token: 0x060048C0 RID: 18624 RVA: 0x0019AF1C File Offset: 0x0019911C
		// (set) Token: 0x060048C1 RID: 18625 RVA: 0x00025503 File Offset: 0x00023703
		public unsafe static Dictionary<int, ValueTuple<IAssetHandle<Sprite>, IAssetHandle<Sprite>>> _SpecialGuestSpellPortrayal_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseNight.NativeFieldInfoPtr__SpecialGuestSpellPortrayal_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ValueTuple<IAssetHandle<Sprite>, IAssetHandle<Sprite>>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseNight.NativeFieldInfoPtr__SpecialGuestSpellPortrayal_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031F4 RID: 12788
		private static readonly IntPtr NativeFieldInfoPtr__SpecialGuestSpell_k__BackingField;

		// Token: 0x040031F5 RID: 12789
		private static readonly IntPtr NativeFieldInfoPtr__SpecialGuestSpellMapping_k__BackingField;

		// Token: 0x040031F6 RID: 12790
		private static readonly IntPtr NativeFieldInfoPtr__SpecialGuestSpellPortrayal_k__BackingField;

		// Token: 0x040031F7 RID: 12791
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestSpell_Private_Static_get_Dictionary_2_Int32_IAssetHandle_1_SpellBase_0;

		// Token: 0x040031F8 RID: 12792
		private static readonly IntPtr NativeMethodInfoPtr_set_SpecialGuestSpell_Private_Static_set_Void_Dictionary_2_Int32_IAssetHandle_1_SpellBase_0;

		// Token: 0x040031F9 RID: 12793
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestSpellMapping_Private_Static_get_Dictionary_2_Int32_String_0;

		// Token: 0x040031FA RID: 12794
		private static readonly IntPtr NativeMethodInfoPtr_set_SpecialGuestSpellMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0;

		// Token: 0x040031FB RID: 12795
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestSpellPortrayal_Private_Static_get_Dictionary_2_Int32_ValueTuple_2_IAssetHandle_1_Sprite_IAssetHandle_1_Sprite_0;

		// Token: 0x040031FC RID: 12796
		private static readonly IntPtr NativeMethodInfoPtr_set_SpecialGuestSpellPortrayal_Private_Static_set_Void_Dictionary_2_Int32_ValueTuple_2_IAssetHandle_1_Sprite_IAssetHandle_1_Sprite_0;

		// Token: 0x040031FD RID: 12797
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_Dictionary_2_String_DataBaseNightData_Dictionary_2_Int32_ValueTuple_2_IAssetHandle_1_Sprite_IAssetHandle_1_Sprite_0;

		// Token: 0x040031FE RID: 12798
		private static readonly IntPtr NativeMethodInfoPtr_WorkSceneGetSpellPortrayal_Public_Static_Sprite_Int32_Boolean_0;

		// Token: 0x040031FF RID: 12799
		private static readonly IntPtr NativeMethodInfoPtr_WorkSceneGetSpell_Public_Static_SpellBase_Int32_0;

		// Token: 0x04003200 RID: 12800
		private static readonly IntPtr NativeMethodInfoPtr_UnloadWorkSceneData_Public_Static_Void_0;

		// Token: 0x02000AC5 RID: 2757
		public class DataBaseNightData : Il2CppSystem.Object
		{
			// Token: 0x0600CE19 RID: 52761 RVA: 0x0032CA1C File Offset: 0x0032AC1C
			// Note: this type is marked as 'beforefieldinit'.
			static DataBaseNightData()
			{
				Il2CppClassPointerStore<DataBaseNight.DataBaseNightData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseNight>.NativeClassPtr, "DataBaseNightData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseNight.DataBaseNightData>.NativeClassPtr);
				DataBaseNight.DataBaseNightData.NativeFieldInfoPtr__SpecialGuestSpell_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseNight.DataBaseNightData>.NativeClassPtr, "<SpecialGuestSpell>k__BackingField");
				DataBaseNight.DataBaseNightData.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_IAssetHandle_1_SpellBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseNight.DataBaseNightData>.NativeClassPtr, 100677830);
				DataBaseNight.DataBaseNightData.NativeMethodInfoPtr_get_SpecialGuestSpell_Internal_get_Dictionary_2_Int32_IAssetHandle_1_SpellBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseNight.DataBaseNightData>.NativeClassPtr, 100677831);
				DataBaseNight.DataBaseNightData.NativeMethodInfoPtr_set_SpecialGuestSpell_Internal_set_Void_Dictionary_2_Int32_IAssetHandle_1_SpellBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseNight.DataBaseNightData>.NativeClassPtr, 100677832);
			}

			// Token: 0x0600CE1A RID: 52762 RVA: 0x0032CA98 File Offset: 0x0032AC98
			[CallerCount(109)]
			[CachedScanResults(RefRangeStart = 60056, RefRangeEnd = 60165, XrefRangeStart = 60056, XrefRangeEnd = 60165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DataBaseNightData(Dictionary<int, IAssetHandle<SpellBase>> specialGuestSpell) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseNight.DataBaseNightData>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialGuestSpell);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseNight.DataBaseNightData.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_IAssetHandle_1_SpellBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170042FE RID: 17150
			// (get) Token: 0x0600CE1B RID: 52763 RVA: 0x0032CAE4 File Offset: 0x0032ACE4
			// (set) Token: 0x0600CE1C RID: 52764 RVA: 0x0032CB24 File Offset: 0x0032AD24
			public unsafe Dictionary<int, IAssetHandle<SpellBase>> SpecialGuestSpell
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseNight.DataBaseNightData.NativeMethodInfoPtr_get_SpecialGuestSpell_Internal_get_Dictionary_2_Int32_IAssetHandle_1_SpellBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, IAssetHandle<SpellBase>>>(intPtr3) : null;
				}
				[CallerCount(18)]
				[CachedScanResults(RefRangeStart = 44253, RefRangeEnd = 44271, XrefRangeStart = 44253, XrefRangeEnd = 44271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseNight.DataBaseNightData.NativeMethodInfoPtr_set_SpecialGuestSpell_Internal_set_Void_Dictionary_2_Int32_IAssetHandle_1_SpellBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600CE1D RID: 52765 RVA: 0x0006E5EF File Offset: 0x0006C7EF
			public DataBaseNightData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042FD RID: 17149
			// (get) Token: 0x0600CE1E RID: 52766 RVA: 0x0032CB68 File Offset: 0x0032AD68
			// (set) Token: 0x0600CE1F RID: 52767 RVA: 0x0006E5F8 File Offset: 0x0006C7F8
			public unsafe Dictionary<int, IAssetHandle<SpellBase>> _SpecialGuestSpell_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseNight.DataBaseNightData.NativeFieldInfoPtr__SpecialGuestSpell_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, IAssetHandle<SpellBase>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseNight.DataBaseNightData.NativeFieldInfoPtr__SpecialGuestSpell_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400849C RID: 33948
			private static readonly IntPtr NativeFieldInfoPtr__SpecialGuestSpell_k__BackingField;

			// Token: 0x0400849D RID: 33949
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_IAssetHandle_1_SpellBase_0;

			// Token: 0x0400849E RID: 33950
			private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestSpell_Internal_get_Dictionary_2_Int32_IAssetHandle_1_SpellBase_0;

			// Token: 0x0400849F RID: 33951
			private static readonly IntPtr NativeMethodInfoPtr_set_SpecialGuestSpell_Internal_set_Void_Dictionary_2_Int32_IAssetHandle_1_SpellBase_0;
		}

		// Token: 0x02000AC6 RID: 2758
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.DataBaseNight+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CE20 RID: 52768 RVA: 0x0032CB98 File Offset: 0x0032AD98
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DataBaseNight.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseNight>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseNight.__c>.NativeClassPtr);
				DataBaseNight.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseNight.__c>.NativeClassPtr, "<>9");
				DataBaseNight.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseNight.__c>.NativeClassPtr, "<>9__12_0");
				DataBaseNight.__c.NativeFieldInfoPtr___9__12_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseNight.__c>.NativeClassPtr, "<>9__12_1");
				DataBaseNight.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseNight.__c>.NativeClassPtr, 100677834);
				DataBaseNight.__c.NativeMethodInfoPtr__Initialize_b__12_0_Internal_Dictionary_2_Int32_IAssetHandle_1_SpellBase_DataBaseNightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseNight.__c>.NativeClassPtr, 100677835);
				DataBaseNight.__c.NativeMethodInfoPtr__Initialize_b__12_1_Internal_Dictionary_2_Int32_IAssetHandle_1_SpellBase_DataBaseNightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseNight.__c>.NativeClassPtr, 100677836);
			}

			// Token: 0x0600CE21 RID: 52769 RVA: 0x0032CC3C File Offset: 0x0032AE3C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseNight.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseNight.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE22 RID: 52770 RVA: 0x0032CC78 File Offset: 0x0032AE78
			[CallerCount(0)]
			public unsafe Dictionary<int, IAssetHandle<SpellBase>> _Initialize_b__12_0(DataBaseNight.DataBaseNightData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseNight.__c.NativeMethodInfoPtr__Initialize_b__12_0_Internal_Dictionary_2_Int32_IAssetHandle_1_SpellBase_DataBaseNightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, IAssetHandle<SpellBase>>>(intPtr3) : null;
			}

			// Token: 0x0600CE23 RID: 52771 RVA: 0x0032CCC8 File Offset: 0x0032AEC8
			[CallerCount(0)]
			public unsafe Dictionary<int, IAssetHandle<SpellBase>> _Initialize_b__12_1(DataBaseNight.DataBaseNightData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseNight.__c.NativeMethodInfoPtr__Initialize_b__12_1_Internal_Dictionary_2_Int32_IAssetHandle_1_SpellBase_DataBaseNightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, IAssetHandle<SpellBase>>>(intPtr3) : null;
			}

			// Token: 0x0600CE24 RID: 52772 RVA: 0x0006E617 File Offset: 0x0006C817
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042FF RID: 17151
			// (get) Token: 0x0600CE25 RID: 52773 RVA: 0x0032CD18 File Offset: 0x0032AF18
			// (set) Token: 0x0600CE26 RID: 52774 RVA: 0x0006E620 File Offset: 0x0006C820
			public unsafe static DataBaseNight.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseNight.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseNight.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseNight.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004300 RID: 17152
			// (get) Token: 0x0600CE27 RID: 52775 RVA: 0x0032CD40 File Offset: 0x0032AF40
			// (set) Token: 0x0600CE28 RID: 52776 RVA: 0x0006E632 File Offset: 0x0006C832
			public unsafe static Func<DataBaseNight.DataBaseNightData, Dictionary<int, IAssetHandle<SpellBase>>> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseNight.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseNight.DataBaseNightData, Dictionary<int, IAssetHandle<SpellBase>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseNight.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004301 RID: 17153
			// (get) Token: 0x0600CE29 RID: 52777 RVA: 0x0032CD68 File Offset: 0x0032AF68
			// (set) Token: 0x0600CE2A RID: 52778 RVA: 0x0006E644 File Offset: 0x0006C844
			public unsafe static Func<DataBaseNight.DataBaseNightData, Dictionary<int, IAssetHandle<SpellBase>>> __9__12_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseNight.__c.NativeFieldInfoPtr___9__12_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseNight.DataBaseNightData, Dictionary<int, IAssetHandle<SpellBase>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseNight.__c.NativeFieldInfoPtr___9__12_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084A0 RID: 33952
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040084A1 RID: 33953
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x040084A2 RID: 33954
			private static readonly IntPtr NativeFieldInfoPtr___9__12_1;

			// Token: 0x040084A3 RID: 33955
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084A4 RID: 33956
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__12_0_Internal_Dictionary_2_Int32_IAssetHandle_1_SpellBase_DataBaseNightData_0;

			// Token: 0x040084A5 RID: 33957
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__12_1_Internal_Dictionary_2_Int32_IAssetHandle_1_SpellBase_DataBaseNightData_0;
		}
	}
}
