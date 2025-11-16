using System;
using GameData.Profile.SchedulerNodeCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002EB RID: 747
	public class SchedulerProfile : ScriptableObject
	{
		// Token: 0x06005A33 RID: 23091 RVA: 0x001CCC78 File Offset: 0x001CAE78
		// Note: this type is marked as 'beforefieldinit'.
		static SchedulerProfile()
		{
			Il2CppClassPointerStore<SchedulerProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "SchedulerProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchedulerProfile>.NativeClassPtr);
			SchedulerProfile.NativeFieldInfoPtr_allNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerProfile>.NativeClassPtr, "allNodes");
			SchedulerProfile.NativeFieldInfoPtr_allNews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerProfile>.NativeClassPtr, "allNews");
			SchedulerProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerProfile>.NativeClassPtr, 100681425);
		}

		// Token: 0x06005A34 RID: 23092 RVA: 0x001CCCE4 File Offset: 0x001CAEE4
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchedulerProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchedulerProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchedulerProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A35 RID: 23093 RVA: 0x00030BA1 File Offset: 0x0002EDA1
		public SchedulerProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F15 RID: 7957
		// (get) Token: 0x06005A36 RID: 23094 RVA: 0x001CCD20 File Offset: 0x001CAF20
		// (set) Token: 0x06005A37 RID: 23095 RVA: 0x00030BAA File Offset: 0x0002EDAA
		public unsafe Il2CppReferenceArray<SchedulerNode> allNodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerProfile.NativeFieldInfoPtr_allNodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SchedulerNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerProfile.NativeFieldInfoPtr_allNodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F16 RID: 7958
		// (get) Token: 0x06005A38 RID: 23096 RVA: 0x001CCD50 File Offset: 0x001CAF50
		// (set) Token: 0x06005A39 RID: 23097 RVA: 0x00030BC9 File Offset: 0x0002EDC9
		public unsafe Il2CppReferenceArray<NewsNode> allNews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerProfile.NativeFieldInfoPtr_allNews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NewsNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerProfile.NativeFieldInfoPtr_allNews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003C15 RID: 15381
		private static readonly IntPtr NativeFieldInfoPtr_allNodes;

		// Token: 0x04003C16 RID: 15382
		private static readonly IntPtr NativeFieldInfoPtr_allNews;

		// Token: 0x04003C17 RID: 15383
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
