using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x02000250 RID: 592
	public static class EventCoroutineDelegation : Il2CppSystem.Object
	{
		// Token: 0x06004A18 RID: 18968 RVA: 0x001A0C58 File Offset: 0x0019EE58
		// Note: this type is marked as 'beforefieldinit'.
		static EventCoroutineDelegation()
		{
			Il2CppClassPointerStore<EventCoroutineDelegation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility", "EventCoroutineDelegation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventCoroutineDelegation>.NativeClassPtr);
			EventCoroutineDelegation.NativeMethodInfoPtr_Schedule_Public_Static_Coroutine_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCoroutineDelegation>.NativeClassPtr, 100678237);
			EventCoroutineDelegation.NativeMethodInfoPtr_Stop_Public_Static_Void_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCoroutineDelegation>.NativeClassPtr, 100678238);
		}

		// Token: 0x06004A19 RID: 18969 RVA: 0x001A0CB0 File Offset: 0x0019EEB0
		[CallerCount(84)]
		[CachedScanResults(RefRangeStart = 193740, RefRangeEnd = 193824, XrefRangeStart = 193735, XrefRangeEnd = 193740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Coroutine Schedule(this IEnumerator coroutineHandle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coroutineHandle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCoroutineDelegation.NativeMethodInfoPtr_Schedule_Public_Static_Coroutine_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
		}

		// Token: 0x06004A1A RID: 18970 RVA: 0x001A0CF4 File Offset: 0x0019EEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193824, XrefRangeEnd = 193829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Stop(this Coroutine coroutine)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coroutine);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCoroutineDelegation.NativeMethodInfoPtr_Stop_Public_Static_Void_Coroutine_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A1B RID: 18971 RVA: 0x00025DAC File Offset: 0x00023FAC
		public EventCoroutineDelegation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003307 RID: 13063
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Public_Static_Coroutine_IEnumerator_0;

		// Token: 0x04003308 RID: 13064
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Static_Void_Coroutine_0;
	}
}
