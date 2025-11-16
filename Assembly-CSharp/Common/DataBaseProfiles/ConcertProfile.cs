using System;
using Cysharp.Threading.Tasks;
using DEYU.AssetHandleUtility;
using GameData;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Common.DataBaseProfiles
{
	// Token: 0x020003D9 RID: 985
	public class ConcertProfile : ScriptableObject
	{
		// Token: 0x060075D0 RID: 30160 RVA: 0x00227424 File Offset: 0x00225624
		// Note: this type is marked as 'beforefieldinit'.
		static ConcertProfile()
		{
			Il2CppClassPointerStore<ConcertProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.DataBaseProfiles", "ConcertProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcertProfile>.NativeClassPtr);
			ConcertProfile.NativeFieldInfoPtr__cg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcertProfile>.NativeClassPtr, "_cg");
			ConcertProfile.NativeFieldInfoPtr__lyrics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcertProfile>.NativeClassPtr, "_lyrics");
			ConcertProfile.NativeFieldInfoPtr__music = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcertProfile>.NativeClassPtr, "_music");
			ConcertProfile.NativeFieldInfoPtr__endCGDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcertProfile>.NativeClassPtr, "_endCGDuration");
			ConcertProfile.NativeFieldInfoPtr__showLyrics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcertProfile>.NativeClassPtr, "_showLyrics");
			ConcertProfile.NativeFieldInfoPtr__concertPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcertProfile>.NativeClassPtr, "_concertPage");
			ConcertProfile.NativeMethodInfoPtr_LoadAssets_Public_UniTask_1_ValueTuple_4_IAssetHandle_1_Sprite_IAssetHandle_1_TextAsset_IAssetHandle_1_LoopedBGMPackage_IGameObjectAssetHandle_1_CanvasGroup_byref_Single_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcertProfile>.NativeClassPtr, 100687467);
			ConcertProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcertProfile>.NativeClassPtr, 100687468);
		}

		// Token: 0x060075D1 RID: 30161 RVA: 0x002274F4 File Offset: 0x002256F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292464, RefRangeEnd = 292465, XrefRangeStart = 292440, XrefRangeEnd = 292464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask<ValueTuple<IAssetHandle<Sprite>, IAssetHandle<TextAsset>, IAssetHandle<LoopedBGMPackage>, IGameObjectAssetHandle<CanvasGroup>>> LoadAssets(out float endCGDuration, out bool showLyrics)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &endCGDuration;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &showLyrics;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ConcertProfile.NativeMethodInfoPtr_LoadAssets_Public_UniTask_1_ValueTuple_4_IAssetHandle_1_Sprite_IAssetHandle_1_TextAsset_IAssetHandle_1_LoopedBGMPackage_IGameObjectAssetHandle_1_CanvasGroup_byref_Single_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<ValueTuple<IAssetHandle<Sprite>, IAssetHandle<TextAsset>, IAssetHandle<LoopedBGMPackage>, IGameObjectAssetHandle<CanvasGroup>>>(pointer);
		}

		// Token: 0x060075D2 RID: 30162 RVA: 0x00227548 File Offset: 0x00225748
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConcertProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcertProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcertProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075D3 RID: 30163 RVA: 0x0003FBEA File Offset: 0x0003DDEA
		public ConcertProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700283E RID: 10302
		// (get) Token: 0x060075D4 RID: 30164 RVA: 0x00227584 File Offset: 0x00225784
		// (set) Token: 0x060075D5 RID: 30165 RVA: 0x0003FBF3 File Offset: 0x0003DDF3
		public unsafe AssetReference _cg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcertProfile.NativeFieldInfoPtr__cg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcertProfile.NativeFieldInfoPtr__cg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700283F RID: 10303
		// (get) Token: 0x060075D6 RID: 30166 RVA: 0x002275B4 File Offset: 0x002257B4
		// (set) Token: 0x060075D7 RID: 30167 RVA: 0x0003FC12 File Offset: 0x0003DE12
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference _lyrics
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcertProfile.NativeFieldInfoPtr__lyrics);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcertProfile.NativeFieldInfoPtr__lyrics), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002840 RID: 10304
		// (get) Token: 0x060075D8 RID: 30168 RVA: 0x002275E4 File Offset: 0x002257E4
		// (set) Token: 0x060075D9 RID: 30169 RVA: 0x0003FC31 File Offset: 0x0003DE31
		public unsafe AssetReference _music
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcertProfile.NativeFieldInfoPtr__music);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcertProfile.NativeFieldInfoPtr__music), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002841 RID: 10305
		// (get) Token: 0x060075DA RID: 30170 RVA: 0x00227614 File Offset: 0x00225814
		// (set) Token: 0x060075DB RID: 30171 RVA: 0x0003FC50 File Offset: 0x0003DE50
		public unsafe float _endCGDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcertProfile.NativeFieldInfoPtr__endCGDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcertProfile.NativeFieldInfoPtr__endCGDuration)) = value;
			}
		}

		// Token: 0x17002842 RID: 10306
		// (get) Token: 0x060075DC RID: 30172 RVA: 0x0022763C File Offset: 0x0022583C
		// (set) Token: 0x060075DD RID: 30173 RVA: 0x0003FC6B File Offset: 0x0003DE6B
		public unsafe bool _showLyrics
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcertProfile.NativeFieldInfoPtr__showLyrics);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcertProfile.NativeFieldInfoPtr__showLyrics)) = value;
			}
		}

		// Token: 0x17002843 RID: 10307
		// (get) Token: 0x060075DE RID: 30174 RVA: 0x00227664 File Offset: 0x00225864
		// (set) Token: 0x060075DF RID: 30175 RVA: 0x0003FC86 File Offset: 0x0003DE86
		public unsafe AssetReference _concertPage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcertProfile.NativeFieldInfoPtr__concertPage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcertProfile.NativeFieldInfoPtr__concertPage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004E12 RID: 19986
		private static readonly IntPtr NativeFieldInfoPtr__cg;

		// Token: 0x04004E13 RID: 19987
		private static readonly IntPtr NativeFieldInfoPtr__lyrics;

		// Token: 0x04004E14 RID: 19988
		private static readonly IntPtr NativeFieldInfoPtr__music;

		// Token: 0x04004E15 RID: 19989
		private static readonly IntPtr NativeFieldInfoPtr__endCGDuration;

		// Token: 0x04004E16 RID: 19990
		private static readonly IntPtr NativeFieldInfoPtr__showLyrics;

		// Token: 0x04004E17 RID: 19991
		private static readonly IntPtr NativeFieldInfoPtr__concertPage;

		// Token: 0x04004E18 RID: 19992
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssets_Public_UniTask_1_ValueTuple_4_IAssetHandle_1_Sprite_IAssetHandle_1_TextAsset_IAssetHandle_1_LoopedBGMPackage_IGameObjectAssetHandle_1_CanvasGroup_byref_Single_byref_Boolean_0;

		// Token: 0x04004E19 RID: 19993
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
