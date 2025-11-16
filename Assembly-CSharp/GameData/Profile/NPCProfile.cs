using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002F2 RID: 754
	public class NPCProfile : ScriptableObject
	{
		// Token: 0x06005A64 RID: 23140 RVA: 0x001CD3A8 File Offset: 0x001CB5A8
		// Note: this type is marked as 'beforefieldinit'.
		static NPCProfile()
		{
			Il2CppClassPointerStore<NPCProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "NPCProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCProfile>.NativeClassPtr);
			NPCProfile.NativeFieldInfoPtr_allNPCData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCProfile>.NativeClassPtr, "allNPCData");
			NPCProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProfile>.NativeClassPtr, 100681432);
		}

		// Token: 0x06005A65 RID: 23141 RVA: 0x001CD400 File Offset: 0x001CB600
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A66 RID: 23142 RVA: 0x00030D8E File Offset: 0x0002EF8E
		public NPCProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F23 RID: 7971
		// (get) Token: 0x06005A67 RID: 23143 RVA: 0x001CD43C File Offset: 0x001CB63C
		// (set) Token: 0x06005A68 RID: 23144 RVA: 0x00030D97 File Offset: 0x0002EF97
		public unsafe Il2CppReferenceArray<NPC> allNPCData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCProfile.NativeFieldInfoPtr_allNPCData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCProfile.NativeFieldInfoPtr_allNPCData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003C2A RID: 15402
		private static readonly IntPtr NativeFieldInfoPtr_allNPCData;

		// Token: 0x04003C2B RID: 15403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
