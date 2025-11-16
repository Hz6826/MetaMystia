using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace DayScene.Interactables.Collectable
{
	// Token: 0x02000199 RID: 409
	public class CollectableProfile : ScriptableObject
	{
		// Token: 0x06002BD6 RID: 11222 RVA: 0x0012FF50 File Offset: 0x0012E150
		// Note: this type is marked as 'beforefieldinit'.
		static CollectableProfile()
		{
			Il2CppClassPointerStore<CollectableProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collectable", "CollectableProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectableProfile>.NativeClassPtr);
			CollectableProfile.NativeFieldInfoPtr_collectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectableProfile>.NativeClassPtr, "collectables");
			CollectableProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectableProfile>.NativeClassPtr, 100670957);
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x0012FFA8 File Offset: 0x0012E1A8
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CollectableProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectableProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectableProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BD8 RID: 11224 RVA: 0x000198B3 File Offset: 0x00017AB3
		public CollectableProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06002BD9 RID: 11225 RVA: 0x0012FFE4 File Offset: 0x0012E1E4
		// (set) Token: 0x06002BDA RID: 11226 RVA: 0x000198BC File Offset: 0x00017ABC
		public unsafe Il2CppReferenceArray<Collectable> collectables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectableProfile.NativeFieldInfoPtr_collectables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collectable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectableProfile.NativeFieldInfoPtr_collectables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D04 RID: 7428
		private static readonly IntPtr NativeFieldInfoPtr_collectables;

		// Token: 0x04001D05 RID: 7429
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
