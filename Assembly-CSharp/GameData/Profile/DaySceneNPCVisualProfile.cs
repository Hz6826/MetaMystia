using System;
using GameData.Core.Collections.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002D0 RID: 720
	public class DaySceneNPCVisualProfile : ScriptableObject
	{
		// Token: 0x06005894 RID: 22676 RVA: 0x001C8E14 File Offset: 0x001C7014
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneNPCVisualProfile()
		{
			Il2CppClassPointerStore<DaySceneNPCVisualProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "DaySceneNPCVisualProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneNPCVisualProfile>.NativeClassPtr);
			DaySceneNPCVisualProfile.NativeFieldInfoPtr_allVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneNPCVisualProfile>.NativeClassPtr, "allVisuals");
			DaySceneNPCVisualProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneNPCVisualProfile>.NativeClassPtr, 100681269);
		}

		// Token: 0x06005895 RID: 22677 RVA: 0x001C8E6C File Offset: 0x001C706C
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneNPCVisualProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneNPCVisualProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneNPCVisualProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005896 RID: 22678 RVA: 0x0002F7B8 File Offset: 0x0002D9B8
		public DaySceneNPCVisualProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E71 RID: 7793
		// (get) Token: 0x06005897 RID: 22679 RVA: 0x001C8EA8 File Offset: 0x001C70A8
		// (set) Token: 0x06005898 RID: 22680 RVA: 0x0002F7C1 File Offset: 0x0002D9C1
		public unsafe Il2CppReferenceArray<DaySceneNPCVisualProfile.IDVisualPair> allVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneNPCVisualProfile.NativeFieldInfoPtr_allVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DaySceneNPCVisualProfile.IDVisualPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneNPCVisualProfile.NativeFieldInfoPtr_allVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B49 RID: 15177
		private static readonly IntPtr NativeFieldInfoPtr_allVisuals;

		// Token: 0x04003B4A RID: 15178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C93 RID: 3219
		[Serializable]
		public sealed class IDVisualPair : ValueType
		{
			// Token: 0x0600E730 RID: 59184 RVA: 0x00376E44 File Offset: 0x00375044
			// Note: this type is marked as 'beforefieldinit'.
			static IDVisualPair()
			{
				Il2CppClassPointerStore<DaySceneNPCVisualProfile.IDVisualPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneNPCVisualProfile>.NativeClassPtr, "IDVisualPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneNPCVisualProfile.IDVisualPair>.NativeClassPtr);
				DaySceneNPCVisualProfile.IDVisualPair.NativeFieldInfoPtr_characterID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneNPCVisualProfile.IDVisualPair>.NativeClassPtr, "characterID");
				DaySceneNPCVisualProfile.IDVisualPair.NativeFieldInfoPtr_visual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneNPCVisualProfile.IDVisualPair>.NativeClassPtr, "visual");
			}

			// Token: 0x0600E731 RID: 59185 RVA: 0x0007B6B9 File Offset: 0x000798B9
			public IDVisualPair(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E732 RID: 59186 RVA: 0x0007B6C2 File Offset: 0x000798C2
			public IDVisualPair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneNPCVisualProfile.IDVisualPair>.NativeClassPtr))
			{
			}

			// Token: 0x17004AF9 RID: 19193
			// (get) Token: 0x0600E733 RID: 59187 RVA: 0x00376E98 File Offset: 0x00375098
			// (set) Token: 0x0600E734 RID: 59188 RVA: 0x0007B6D4 File Offset: 0x000798D4
			public unsafe int characterID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneNPCVisualProfile.IDVisualPair.NativeFieldInfoPtr_characterID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneNPCVisualProfile.IDVisualPair.NativeFieldInfoPtr_characterID)) = value;
				}
			}

			// Token: 0x17004AFA RID: 19194
			// (get) Token: 0x0600E735 RID: 59189 RVA: 0x00376EC0 File Offset: 0x003750C0
			// (set) Token: 0x0600E736 RID: 59190 RVA: 0x0007B6EF File Offset: 0x000798EF
			public unsafe CharacterSpriteSetCompact visual
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneNPCVisualProfile.IDVisualPair.NativeFieldInfoPtr_visual);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneNPCVisualProfile.IDVisualPair.NativeFieldInfoPtr_visual), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400939B RID: 37787
			private static readonly IntPtr NativeFieldInfoPtr_characterID;

			// Token: 0x0400939C RID: 37788
			private static readonly IntPtr NativeFieldInfoPtr_visual;
		}
	}
}
