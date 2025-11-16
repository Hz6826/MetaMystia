using System;
using Cysharp.Threading.Tasks;
using DEYU.AssetHandleUtility;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.AddressableAssets;

namespace GameData.Profile
{
	// Token: 0x02000319 RID: 793
	[Serializable]
	public class SpellIdPair : Object
	{
		// Token: 0x06005E23 RID: 24099 RVA: 0x001D76F0 File Offset: 0x001D58F0
		// Note: this type is marked as 'beforefieldinit'.
		static SpellIdPair()
		{
			Il2CppClassPointerStore<SpellIdPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "SpellIdPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellIdPair>.NativeClassPtr);
			SpellIdPair.NativeFieldInfoPtr_guestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellIdPair>.NativeClassPtr, "guestId");
			SpellIdPair.NativeFieldInfoPtr_notShowInNotebook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellIdPair>.NativeClassPtr, "notShowInNotebook");
			SpellIdPair.NativeFieldInfoPtr_m_SpellAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellIdPair>.NativeClassPtr, "m_SpellAsset");
			SpellIdPair.NativeMethodInfoPtr_get_HasSpell_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellIdPair>.NativeClassPtr, 100682624);
			SpellIdPair.NativeMethodInfoPtr_LoadSpellAssetAsync_Public_UniTask_1_IAssetHandle_1_SpellBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellIdPair>.NativeClassPtr, 100682625);
			SpellIdPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellIdPair>.NativeClassPtr, 100682626);
		}

		// Token: 0x17002082 RID: 8322
		// (get) Token: 0x06005E24 RID: 24100 RVA: 0x001D7798 File Offset: 0x001D5998
		public unsafe bool HasSpell
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 233875, RefRangeEnd = 233877, XrefRangeStart = 233875, XrefRangeEnd = 233875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellIdPair.NativeMethodInfoPtr_get_HasSpell_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005E25 RID: 24101 RVA: 0x001D77D4 File Offset: 0x001D59D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233884, RefRangeEnd = 233885, XrefRangeStart = 233877, XrefRangeEnd = 233884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask<IAssetHandle<SpellBase>> LoadSpellAssetAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SpellIdPair.NativeMethodInfoPtr_LoadSpellAssetAsync_Public_UniTask_1_IAssetHandle_1_SpellBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<IAssetHandle<SpellBase>>(pointer);
		}

		// Token: 0x06005E26 RID: 24102 RVA: 0x001D780C File Offset: 0x001D5A0C
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpellIdPair() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellIdPair>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellIdPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E27 RID: 24103 RVA: 0x0003350A File Offset: 0x0003170A
		public SpellIdPair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700207F RID: 8319
		// (get) Token: 0x06005E28 RID: 24104 RVA: 0x001D7848 File Offset: 0x001D5A48
		// (set) Token: 0x06005E29 RID: 24105 RVA: 0x00033513 File Offset: 0x00031713
		public unsafe int guestId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellIdPair.NativeFieldInfoPtr_guestId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellIdPair.NativeFieldInfoPtr_guestId)) = value;
			}
		}

		// Token: 0x17002080 RID: 8320
		// (get) Token: 0x06005E2A RID: 24106 RVA: 0x001D7870 File Offset: 0x001D5A70
		// (set) Token: 0x06005E2B RID: 24107 RVA: 0x0003352E File Offset: 0x0003172E
		public unsafe bool notShowInNotebook
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellIdPair.NativeFieldInfoPtr_notShowInNotebook);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellIdPair.NativeFieldInfoPtr_notShowInNotebook)) = value;
			}
		}

		// Token: 0x17002081 RID: 8321
		// (get) Token: 0x06005E2C RID: 24108 RVA: 0x001D7898 File Offset: 0x001D5A98
		// (set) Token: 0x06005E2D RID: 24109 RVA: 0x00033549 File Offset: 0x00031749
		public unsafe AssetReferenceT<SpellBase> m_SpellAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellIdPair.NativeFieldInfoPtr_m_SpellAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<SpellBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellIdPair.NativeFieldInfoPtr_m_SpellAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003E4A RID: 15946
		private static readonly IntPtr NativeFieldInfoPtr_guestId;

		// Token: 0x04003E4B RID: 15947
		private static readonly IntPtr NativeFieldInfoPtr_notShowInNotebook;

		// Token: 0x04003E4C RID: 15948
		private static readonly IntPtr NativeFieldInfoPtr_m_SpellAsset;

		// Token: 0x04003E4D RID: 15949
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSpell_Public_get_Boolean_0;

		// Token: 0x04003E4E RID: 15950
		private static readonly IntPtr NativeMethodInfoPtr_LoadSpellAssetAsync_Public_UniTask_1_IAssetHandle_1_SpellBase_0;

		// Token: 0x04003E4F RID: 15951
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
