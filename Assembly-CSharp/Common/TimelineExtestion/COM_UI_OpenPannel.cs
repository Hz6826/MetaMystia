using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x0200040C RID: 1036
	public class COM_UI_OpenPannel : PlayableAsset
	{
		// Token: 0x06007776 RID: 30582 RVA: 0x0022C218 File Offset: 0x0022A418
		// Note: this type is marked as 'beforefieldinit'.
		static COM_UI_OpenPannel()
		{
			Il2CppClassPointerStore<COM_UI_OpenPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_UI_OpenPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_UI_OpenPannel>.NativeClassPtr);
			COM_UI_OpenPannel.NativeFieldInfoPtr_pannelGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_UI_OpenPannel>.NativeClassPtr, "pannelGameObject");
			COM_UI_OpenPannel.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_UI_OpenPannel>.NativeClassPtr, 100687579);
			COM_UI_OpenPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_UI_OpenPannel>.NativeClassPtr, 100687580);
		}

		// Token: 0x06007777 RID: 30583 RVA: 0x0022C284 File Offset: 0x0022A484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293227, XrefRangeEnd = 293240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_UI_OpenPannel.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007778 RID: 30584 RVA: 0x0022C2EC File Offset: 0x0022A4EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_UI_OpenPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_UI_OpenPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_UI_OpenPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007779 RID: 30585 RVA: 0x00040938 File Offset: 0x0003EB38
		public COM_UI_OpenPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028A9 RID: 10409
		// (get) Token: 0x0600777A RID: 30586 RVA: 0x0022C328 File Offset: 0x0022A528
		// (set) Token: 0x0600777B RID: 30587 RVA: 0x00040941 File Offset: 0x0003EB41
		public unsafe GameObject pannelGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_UI_OpenPannel.NativeFieldInfoPtr_pannelGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_UI_OpenPannel.NativeFieldInfoPtr_pannelGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004EEA RID: 20202
		private static readonly IntPtr NativeFieldInfoPtr_pannelGameObject;

		// Token: 0x04004EEB RID: 20203
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004EEC RID: 20204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
